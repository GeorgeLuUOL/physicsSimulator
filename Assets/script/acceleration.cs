using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acceleration : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D r2d;
    public Vector2 acc;
    private Text outputA;
    private Text outputV;
    double pi = Math.PI;

     //string t_a = outputA.GetComponent<Text>().text;
    //public float forceX;
    //public float forceY;
   // public float u;
    void Start()
    {
        r2d = GameObject.Find("cube").GetComponent<Rigidbody2D>();
        outputA=GameObject.Find("Output_a").GetComponent<Text>();
        outputV=GameObject.Find("Output_v").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        r2d.AddForce(acc*r2d.mass);
        double accx = Convert.ToDouble(acc.x);
        double accy = Convert.ToDouble(acc.y);
        //Math.Atan(accy/accx);
        double vx = r2d.velocity.x;
        double vy = r2d.velocity.y;
        
        double resultant_v=Math.Sqrt(vx * vx + vy * vy);
        double resultant_a = Math.Sqrt(accx * accx + accy * accy);
        outputA.text = "resultant a :"+Convert.ToString(resultant_a)+" angle:"+Math.Atan(accy/accx)*180/pi;
        outputV.text = "velocity:" + Convert.ToString(resultant_v);
        Debug.Log("force set");
    }
}
