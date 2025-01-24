using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timescript : MonoBehaviour
{
    private Text tim;
    public static float count = 10f;
    public GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tim = GetComponent<Text>();
        count -= Time.deltaTime;
        tim.text = "Time Left:" +
            Mathf.Round(count);
        if(count<=0)
        {
            finish.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
