﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forball : MonoBehaviour
{
public float speed=1f;
public float e = 1f;

private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
	rigidBody.velocity=new Vector2(speed,0f);

    }

    public void setSpeed(float s)
    {
        this.speed = s;
        //Debug.Log("speed set");
    }

   

    void OnCollisionEnter2D(Collision2D col)
    {
        //float v1 = GameObject.Find("ballLeft").GetComponent<forball>().speed;
       
        
        if (col.gameObject.tag.Equals("ball"))
        {
            float v1 = this.speed;
            string temp = col.gameObject.name;
            float v2=GameObject.Find(temp).GetComponent<forball>().speed;
            float m1 = this.rigidBody.mass;
            float m2 = GameObject.Find(temp).GetComponent<Rigidbody2D>().mass;
            
            
            
            Debug.Log("collision detected"+v1+" "+" "+v2+" "+m1+" "+m2);
            //GameObject.Find("ballLeft").GetComponent<forball>().setSpeed(-2f);
            this.setSpeed(calculateV1(v1,v2,m1,m2,e));
            GameObject.Find(temp).GetComponent<forball>().setSpeed(calculateV2(v1,v2,m1,m2,e));
             Debug.Log("collision detected"+calculateV1(v1,v2,m1,m2,e)+" "+" "+calculateV2(v1,v2,m1,m2,e)+" "+m1+" "+m2);

             GameObject.Find("speedG").GetComponent<Text>().text = "Speed of Green Ball: " + v1;
             GameObject.Find("speedR").GetComponent<Text>().text = "Speed of Red Ball: " + v2;
        }
    }

   
 float calculateV1(float v1, float v2, float m1, float m2, float e)
    {
        return (v1 * (m1 - e * m2) + (1 + e) * m2 * v2) / (m1 + m2);

    }
 
 float calculateV2(float v1, float v2, float m1, float m2, float e)
 {
     return ((1+e)*m1*v1+(m2-e*m1)*v2)/(m1+m2);

 }
}
