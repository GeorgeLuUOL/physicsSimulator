using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VecL : MonoBehaviour
{
    private Vector2 pos;
   
    private GameObject ballR;
   
    public float scale;
    // Start is called before the first frame update
    void Start()
    {
        ballR = GameObject.Find("ballLeft");
    }
   
    // Update is called once per frame
    void Update()
    {
        float newPosX = ballR.transform.position.x;
        float newPosY=ballR.transform.position.y;
          
        this.transform.position=new Vector3(newPosX,newPosY);
        //this.transform.localScale.x=new Vector3();
        changeScale(this.scale);
    }
   
    void changeScale(float scale)
    {
        scale = this.scale;
        this.transform.localScale = new Vector3(scale,1.5f);
    }
}
