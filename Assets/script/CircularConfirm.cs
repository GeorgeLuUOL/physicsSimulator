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

    public void openDocument()
    {
        GameObject.Find("documentPa").transform.Find("document").gameObject.SetActive(true);
    }
    public void closeDocument()
    {
        GameObject.Find("documentPa").transform.Find("document").gameObject.SetActive(false);
    }

    public void openQuestion()
    {
        GameObject Q = GameObject.Find("QuestionPartPa");
        Q.transform.Find("QuestionPart").gameObject.SetActive(true);
        //Q.GetComponent<generateQuestion>().generateRandomQuestion();
    }
    public void closeQuestion()
    {
        GameObject.Find("QuestionPartPa").transform.Find("QuestionPart").gameObject.SetActive(false);
    }

}
