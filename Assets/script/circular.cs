using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circular : MonoBehaviour
{
    public float speed = 1f;
    public float force =1f;

    private static float midX = 4f;

    private static float midY = 0f;
    
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity=new Vector2(speed,0f);
    }

    // Update is called once per frame
    void Update()
    {
        float currX = this.transform.position.x-midX;
        float currY = this.transform.position.y-midY;
        
        float hypoteinousa = Convert.ToSingle(Math.Sqrt(currX * currX + currY * currY));
        
        float forceX = currX / hypoteinousa * force;
        float forceY = currY / hypoteinousa * force;
        rigidBody.AddForce(new Vector2(-forceX,-forceY));
        Debug.Log(hypoteinousa);
    }
}
