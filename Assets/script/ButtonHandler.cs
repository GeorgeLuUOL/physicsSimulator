using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public void getInput()
    {
        GameObject inputSpeedForBallLeft;
        GameObject inputSpeedForBallRight;
        GameObject inputMass;
        GameObject inputMassR;
        GameObject ballL;
        GameObject ballR;
        
        inputSpeedForBallLeft = GameObject.Find("inputSpeed");
        string textValue = inputSpeedForBallLeft.GetComponentInChildren<InputField>().text;
        
        inputSpeedForBallRight = GameObject.Find("inputSpeedR");
        string textValueR = inputSpeedForBallRight.GetComponentInChildren<InputField>().text;
        
        float speedL=Convert.ToSingle(textValue);
        float speedR = Convert.ToSingle(textValueR);
        
        inputMass = GameObject.Find("inputMass");
        string massV = inputMass.GetComponentInChildren<InputField>().text;
        
        inputMassR = GameObject.Find("inputMassR");
        string massVR = inputMassR.GetComponentInChildren<InputField>().text;
        
        float massL=Convert.ToSingle(massV);
        float massR = Convert.ToSingle(massVR);
        
        ballL = GameObject.Find("ballLeft");
        ballR = GameObject.Find("ballRight");
        ballL.GetComponent<forball>().setSpeed(speedL);
        ballR.GetComponent<forball>().setSpeed(speedR);
        ballL.GetComponent<Rigidbody2D>().mass = massL;
        ballR.GetComponent<Rigidbody2D>().mass = massR;
        //currentSpeed = speedL;
        //string textValue = "aa";
        //Debug.Log(textValue+"");
    }
}
