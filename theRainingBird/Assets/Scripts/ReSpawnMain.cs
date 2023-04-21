using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawnMain : MonoBehaviour
{    
    public Vector3 startingPosition;
    public Quaternion startingRotation;
    private float lowBound =235.0f;

    // Start is called before the first frame update
    void Start()
    {

        startingPosition = transform.position+ new Vector3(0, 1, 0);
        startingRotation = transform.rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowBound)
        {
            transform.position = startingPosition;
            transform.rotation = startingRotation;
        }
        // } else if (transform.position.z < lowBound)
        // {
        //     Debug.Log("Game Over!");
        //     Destroy(gameObject);
        // } 

        
    }
}
