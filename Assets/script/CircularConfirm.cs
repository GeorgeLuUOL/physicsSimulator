using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircularConfirm : MonoBehaviour
{
    private GameObject mass;
    private GameObject velocity;
    private GameObject R;
    private GameObject gravity;
    private GameObject moon;
    public void setVariable()
    {
        //mass = GameObject.Find("inputMass");
        velocity = GameObject.Find("inputV");
       
        gravity = GameObject.Find("InputGravity");

        moon = GameObject.Find("moon");

        string v = velocity.GetComponent<InputField>().text;
        string gra = gravity.GetComponent<InputField>().text;

        float Inputv = Convert.ToSingle(v);
        
        float Inputg = Convert.ToSingle(gra);
        moon.GetComponent<circular>().speed = Inputv;
        Debug.Log( moon.GetComponent<circular>().speed);
        moon.GetComponent<circular>().gravity = Inputg;
        this.gameObject.SetActive(false);

    }
}
