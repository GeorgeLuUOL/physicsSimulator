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
        float accX;
        if (InputForceX - InputU * InputMass * 10 < 0)
        {
            accX = 0;
        }
        else
        {
            accX = (InputForceX - InputU * InputMass * 10) / InputMass;
        }

        float accY;
        if (InputMass * 10 >= InputForceY)
        {
            accY = 0;
        }
        else
        {
            accY = (InputForceY - InputMass * 10) / InputMass;
        }

        cube.GetComponent<acceleration>().acc.x = accX;
        cube.GetComponent<acceleration>().acc.y = accY;
    }
}
