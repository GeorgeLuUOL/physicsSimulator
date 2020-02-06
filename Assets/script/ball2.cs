using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball2 : MonoBehaviour
{
 public float speed=1f;
 
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
    
}
