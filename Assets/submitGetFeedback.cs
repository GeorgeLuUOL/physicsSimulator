using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class submitGetFeedback : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getFeedBack()
    {
        int answer = Convert.ToInt32(GameObject.Find("InputAnswer").GetComponent<InputField>().text);
        int presume = GameObject.Find("Question2").GetComponent<scriptForQuestion>().time;
        int exactAnswer = 5*presume*presume;
        if (answer == exactAnswer)
        {
            GameObject.Find("Answer").GetComponent<TextMeshProUGUI>().color=Color.green;
            GameObject.Find("Answer").GetComponent<TextMeshProUGUI>().text = "Correct";
            

        }
        else
        {
            GameObject.Find("Answer").GetComponent<TextMeshProUGUI>().color=Color.red;
            GameObject.Find("Answer").GetComponent<TextMeshProUGUI>().text = "False, the correct answer is "+exactAnswer;
            
        }
    }
}
