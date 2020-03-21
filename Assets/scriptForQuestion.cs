using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptForQuestion : MonoBehaviour
{
    public int time = 1;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text =
            "Assume g=10m/s^2, a ball is doing free fall motion. Its initial velocity is 0 in each direction." +
            " after " + time + "s. the distance of the ball to the origin is." +
            "(Assume the height of the ball to the ground is large enough)";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setContent(int time)
    {
        this.time = time;
        this.GetComponent<Text>().text=  "Assume g=10m/s^2, a ball is doing free fall motion. Its initial velocity is 0 in each direction." +
                                         " after " + time + "s. the distance of the ball to the origin is." +
                                         "(Assume the height of the ball to the ground is large enough)";
        
    }
}
