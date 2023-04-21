using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound =260.0f;
    //private float lowBound =200.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
        // } else if (transform.position.z < lowBound)
        // {
        //     Debug.Log("Game Over!");
        //     Destroy(gameObject);
        // } 

        
    }
}
