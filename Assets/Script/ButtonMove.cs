using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    private float leftSpeed=0f, rightSpeed=0f;

    public void LeftButton()
    {
        leftSpeed = 1f;
    }

    public void RightButton()
    {
        rightSpeed = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-leftSpeed * Time.deltaTime, 0, 0);
        
        transform.Translate(rightSpeed * Time.deltaTime, 0, 0);
        
    }
}
