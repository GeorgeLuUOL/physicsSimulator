using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public string obj;

    public Animator transition;
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
        GameObject.Find("speedG").GetComponent<Text>().text = "Speed of Green Ball: " + speedL;
        GameObject.Find("speedR").GetComponent<Text>().text = "Speed of Red Ball: " + speedR;
        ballL.GetComponent<Rigidbody2D>().mass = massL;
        ballR.GetComponent<Rigidbody2D>().mass = massR;
        GameObject.Find("VecR").GetComponent<vecR>().scale = speedR;
        GameObject.Find("VecL").GetComponent<VecL>().scale = speedL;
        //currentSpeed = speedL;
        //string textValue = "aa";
        //Debug.Log(textValue+"");
        this.gameObject.SetActive(false);
    }

    public void restoreForBall()
    {
        Vector3 vL = new Vector3(-2.24f, -0.68f,0f);
        Vector3 vR = new Vector3(2.24f, -0.68f,0f);
        GameObject ballL = GameObject.Find("ballLeft");
        GameObject ballR = GameObject.Find("ballRight");
        ballL.GetComponent<Transform>().position=vL;
        ballR.GetComponent<Transform>().position=vR;

        ballL.GetComponent<Rigidbody2D>().mass = 1;
        ballR.GetComponent<Rigidbody2D>().mass = 1;
        
        ballL.GetComponent<forball>().speed = 0;
        ballR.GetComponent<forball>().speed = 0;
        
        Debug.Log("restore");
        SceneManager.LoadScene(1);
    }

    public void restoreCube()
    {
       // Vector2 V=new Vector2(-6.8f,-2.17f);
       // GameObject cube = GameObject.Find("cube");
       // cube.GetComponent<acceleration>().acc.x = 0;
     //   cube.GetComponent<acceleration>().acc.y = 0;
       // cube.GetComponent<Transform>().position = V;
       SceneManager.LoadScene(2);


    }

    public void highlight(string obj)
    {
        obj = this.obj;
        GameObject gp = GameObject.Find(obj);
        Color temp=gp.GetComponent<Text>().color ;
        float a = temp.a;
        float b = temp.b;
        float r = temp.r;
        float g = temp.g;
        gp.GetComponent<Text>().color=new Color(r,g+20,b+20,a);
    }

    public void loadSceneForM()
    {
        StartCoroutine((LoadScene(1)));
    }

    public void loadSceneForN()
    {
        StartCoroutine((LoadScene(2)));
        
    }

    public void loadSceneForT()
    {
        StartCoroutine((LoadScene(3)));
    }

    IEnumerator LoadScene(int sceneIndex)
    {
        transition.SetTrigger("start");
        
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene(sceneIndex);

    }

    public void loadMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void loadGra()
    {
        SceneManager.LoadScene(3);

    }
}
