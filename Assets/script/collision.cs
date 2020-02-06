using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
     void OnCollisionEnter(Collision col)
    {    
        
        Debug.Log("collision detected");
    }
}
