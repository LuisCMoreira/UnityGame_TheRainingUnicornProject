using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOvertext;
    public TimerToEnd Timer;
    public GameObject chickPlayer;

    private bool gameOn=true;
    private Vector3 goverSpot = new Vector3(-18.5f,-15,18);
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.elapsedTime > 30.00f && gameOn)
        {
        Instantiate(gameOvertext, Timer.transform.position+goverSpot, Timer.transform.rotation);
        Destroy(chickPlayer);
        Destroy(Timer);
        gameOn=false;
        }
    }
}
