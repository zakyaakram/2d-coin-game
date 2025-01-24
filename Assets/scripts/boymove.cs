using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boymove : MonoBehaviour
{

    private Rigidbody2D pic;
    int speed = 30;
    int jump = 55;

    public GameObject sky;
    public GameObject ground;
    public GameObject mountains;
    public GameObject wall;
    public GameObject maincamera;
    public GameObject zombie;
    public AudioSource s1;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pic = GetComponent<Rigidbody2D>();
        int x = 0;
        int y = 0;
        if (Input.GetKey("right"))
        {
            x = speed;
            transform.localScale = new Vector3(4, 4, 1);

            sky.transform.position += Vector3.left * speed * Time.deltaTime;
            ground.transform.position += Vector3.left * speed * Time.deltaTime;
            mountains.transform.position += Vector3.left * speed * Time.deltaTime;
            wall.transform.position += Vector3.left * speed * Time.deltaTime ;
            maincamera.transform.position += Vector3.left * speed * Time.deltaTime;




        }
        else if (Input.GetKey("left"))
        {
            x = -speed;
            transform.localScale = new Vector3(-4,4,1);
            sky.transform.position += Vector3.right * speed * Time.deltaTime;
            ground.transform.position += Vector3.right * speed * Time.deltaTime;
            mountains.transform.position += Vector3.right * speed * Time.deltaTime;
            wall.transform.position += Vector3.right * speed * Time.deltaTime ;
            maincamera.transform.position += Vector3.right * speed * Time.deltaTime;





        }
        else if (Input.GetKey("up"))
        {
            y = jump;
        }
        else
        {
            y = -jump;

        }
        pic.AddForce(new Vector2(x, y));




    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="target")
        {
            Destroy(collision.gameObject);
            coinscore.scorevalue += 10;
            s1.Play();
        }

        if (collision.gameObject.tag == "zombie")
        {
            Destroy(collision.gameObject);
            coinscore.scorevalue -= 10;
            s1.Play();
        }
        if(collision.gameObject.tag=="door")
        {
            Application.LoadLevel("win");
        }
    }

}
