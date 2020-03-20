using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceVec : MonoBehaviour
{

    private Vector2 pos;

    private GameObject cube;

    public float scale;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("cube");
    }

    // Update is called once per frame
    void Update()
    {
        float newPosX = cube.transform.position.x;
        float newPosY=cube.transform.position.y;
        if (this.name.Equals("DragY"))
        {
            this.transform.position=new Vector3(newPosX+0.2f,newPosY);
        }
       
        else
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
