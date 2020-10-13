using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_N2 : MonoBehaviour
{
    public void setVariable()
    {
        GameObject mass;
        GameObject forceX;
        GameObject forceY;
        GameObject u;
        GameObject cube;

        mass = GameObject.Find("mass");
        forceX = GameObject.Find("forceX");
        forceY = GameObject.Find("forceY");
        u = GameObject.Find("u");
        cube = GameObject.Find("cube");

        string CubeMass = mass.GetComponent<InputField>().text;
        string CubeForceX=forceX.GetComponent<InputField>().text;
        string CubeForceY=forceY.GetComponent<InputField>().text;
        string CubeU=u.GetComponent<InputField>().text;

        float InputMass = Convert.ToSingle(CubeMass);
        float InputForceX = Convert.ToSingle(CubeForceX);
        float InputForceY = Convert.ToSingle(CubeForceY);
        float InputU = Convert.ToSingle(CubeU);

        cube.GetComponent<Rigidbody2D>().mass = InputMass;
        float accX=0;
        GameObject.Find("Drag").GetComponent<forceVec>().scale = InputForceX;
        GameObject.Find("Vec2").GetComponent<Text>().text += InputForceX + "N";
        GameObject.Find("DragY").GetComponent<forceVec>().scale = InputForceY/5;
        GameObject.Find("Vec1").GetComponent<Text>().text += InputForceY + "N";
        GameObject.Find("gravity").GetComponent<forceVec>().scale = InputMass*10/5;
        GameObject.Find("Vec3").GetComponent<Text>().text += InputMass*10 + "N";
        if (InputMass * 10 - InputForceY >= 0)
        {
            if (Math.Abs(InputForceX) - InputU * (InputMass * 10 - InputForceY) < 0)
            {
                accX = 0;
                GameObject.Find("f").GetComponent<forceVec>().scale = InputForceX;
                GameObject.Find("Vec4").GetComponent<Text>().text += InputForceX + "N";
            }
            else
            {
                if (InputForceX < 0)
                {

                    GameObject.Find("f").GetComponent<forceVec>().scale = -InputU * (InputMass * 10 - InputForceY);
                    GameObject.Find("Vec4").GetComponent<Text>().text += -InputU * (InputMass * 10 - InputForceY) + "N";
                    accX = (InputForceX + InputU * (InputMass * 10 - InputForceY)) / InputMass;
                }
                else
                {
                    GameObject.Find("f").GetComponent<forceVec>().scale = InputU * (InputMass * 10 - InputForceY);
                    GameObject.Find("Vec4").GetComponent<Text>().text += InputU * (InputMass * 10 - InputForceY) + "N";
                    accX = (InputForceX - InputU * (InputMass * 10 - InputForceY)) / InputMass;
                }
            }
        }
        else
        {
            accX = InputForceX / InputMass;
        }

        float accY;
        if (InputMass * 10 >= InputForceY)
        {
            accY = 0;
            GameObject.Find("N").GetComponent<forceVec>().scale = (InputMass * 10 - InputForceY)/5;
            GameObject.Find("Vec5").GetComponent<Text>().text += (InputMass * 10 - InputForceY)+ "N";
        }
        else
        {
            accY = (InputForceY - InputMass * 10) / InputMass;
            GameObject.Find("Vec5").GetComponent<Text>().text += 0+ "N";
            
        }

        cube.GetComponent<acceleration>().acc.x = accX;
        cube.GetComponent<acceleration>().acc.y = accY;
        this.gameObject.SetActive(false);
    }
}
