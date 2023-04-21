using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerToEnd : MonoBehaviour
{
    public TMP_Text myTMPtimer;

    public float elapsedTime = 0f;
    //public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        elapsedTime += Time.deltaTime;
        //timerText.text 
        myTMPtimer.text = "Time: " + elapsedTime.ToString("F2") + "s";
       
    }
}
