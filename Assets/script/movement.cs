using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
public float speed=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WalkForward();
	

    }

void FixedUpdate()
    {
        //和时间无关，所以移动需要把Time.deltaTime去掉，walkSpeed取值0.1即可
        //transform.position = transform.position + walkSpeed * transform.forward;
    }

    void WalkForward()
    {
        transform.position = transform.position + speed * transform.forward * Time.deltaTime;
    }


}
