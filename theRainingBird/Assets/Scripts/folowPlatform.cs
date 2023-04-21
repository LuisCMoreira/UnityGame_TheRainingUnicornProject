using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowPlatform : MonoBehaviour
{
    public GameObject platformObject; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = platformObject.transform.position;
        transform.rotation = platformObject.transform.rotation;
            
    }
}
