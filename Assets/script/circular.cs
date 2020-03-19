using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circular : MonoBehaviour
{
    public float speed = 1f;
    public float gravity =9.8f;

    private static float midX = 4f;

    private static float midY = 0f;
    
    private Rigidbody2D rigidBody;

    private Vector2 pos;
    private int currLines = 0;

    private LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity=new Vector2(speed,0f);
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity=new Vector2(speed,rigidBody.velocity.y );
       
        float currX = this.transform.position.x-midX;
        float currY = this.transform.position.y-midY;
        
        float hypoteinousa = Convert.ToSingle(Math.Sqrt(currX * currX + currY * currY));
        
        float forceX =rigidBody.mass*gravity;
        float forceY = currY / hypoteinousa * gravity;
        rigidBody.AddForce(new Vector2(0f,-forceX));
        Debug.Log(hypoteinousa);
        pos = new Vector2(this.transform.position.x, this.transform.position.y);
        createLine();
        line.SetPosition(0,pos);
        line.SetPosition(1,pos);
    }
    void createLine()
    {
        //LineRenderer line = this.GetComponent<LineRenderer>();
        line=new GameObject("Line"+currLines).AddComponent<LineRenderer>();
        line.positionCount = 2;
        line.startWidth = 0.05f;
        line.endWidth = 0.05f;
        //line.material = material;
        line.startColor = Color.yellow;
        line.endColor = Color.green;
        
        line.GetComponent<Renderer>().sortingLayerName="New Layer";
        line.useWorldSpace = true;
        line.numCapVertices = 50;
    }
}
