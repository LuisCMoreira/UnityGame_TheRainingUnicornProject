using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreText : MonoBehaviour
{

    public TMP_Text myTMPDirection;

    public ChickControl eatFood;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myTMPDirection.text = "Score :" + eatFood.score ;
    }
}
