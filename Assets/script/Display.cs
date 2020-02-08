using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public  float temp = GameObject.Find("BallL").GetComponent<forball>().speed;
    public GameObject g = GameObject.Find("speedG");
    public string t = GameObject.Find("speedG").GetComponent<Text>().text;
  
    // Start is called before the first frame update
    void Start()
    {
   
   

   
    }

    // Update is called once per frame
    void Update()
    {
        
       setString("Speed of Green Ball" +temp);
    }

    public void setString(string a)
    {
        //float a = GameObject.Find("BallL").GetComponent<forball>().speed;
        t = a;

    }
}
