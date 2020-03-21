using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class generateQuestion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this.generateRandomQuestion();
       // this.GetComponent<Text>().text = "nothing";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateRandomQuestion()
    {
        Random ran=new Random();
        int value=ran.Next(1, 10);
        GameObject g =GameObject.Find("Question2");
        g.GetComponentInChildren<scriptForQuestion>().setContent(value);
       
        //g.GetComponent<scriptForQuestion>().setContent(value);
         GameObject a =GameObject.Find("Answer");
         a.GetComponentInChildren<TextMeshProUGUI>().text = "";
    }
}
