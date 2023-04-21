using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickControl : MonoBehaviour
{
    public float horizontalInput;
    public float speed =4.0f;
    public int score = 0;
    public float turnSpeed =4.0f;
    private float xRange = 16.0f;

    private float onJump;
    private bool jumping=false;
    private float jumpSpeed=15.0f;


    //public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange,transform.position.y ,transform.position.z );

        }
        if (transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange,transform.position.y ,transform.position.z );

        }
       horizontalInput=Input.GetAxis("Horizontal"); 
       
        if(horizontalInput>0)
        {
        transform.rotation= Quaternion.Euler(new Vector3(0, -90, 0));
        transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);
        }
        if(horizontalInput<0)
        {
        transform.rotation= Quaternion.Euler(new Vector3(0, 90, 0));
        transform.Translate(-Vector3.forward * horizontalInput * Time.deltaTime * speed);
        }



      if(Input.GetKeyDown(KeyCode.Space) && jumping==false)
       {
        onJump=transform.position.y;
        jumping=true;

       }
       if(transform.position.y<(onJump+5) && jumping)
       {
        transform.Translate(Vector3.up * Time.deltaTime *jumpSpeed*(1 + 5 - (transform.position.y-onJump)));

       }
       else
       {
        jumping=false;

       }

    }


     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("food"))
    {
        score++;
    }
    }
}



