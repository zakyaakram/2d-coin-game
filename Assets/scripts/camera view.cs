using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject cameraTarget;
    private Transform T;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        T=cameraTarget.transform;
        transform.position=new Vector3(T.position.x,T.position.y,transform.position.z);
    }
}
