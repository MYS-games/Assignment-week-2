using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Oscillator : MonoBehaviour
{
   
    [Tooltip("move")]
    [SerializeField]
    float radius;
    [SerializeField]
    int angle;


    float end_x, end_y;
    Vector3 init_pos;

    // Start is called before the first frame update
    void Start()
    {

        if (angle > 180)
        {
            while(angle > 360)
            {
                angle -= 180;
            }
        }
        if (angle < 0)
        {
            while (angle < 0)
            {
                angle += 180;
            }
        }

        var radians = angle * Mathf.Deg2Rad;
        end_x = init_pos.x + Mathf.Cos(radians) + radius;
        end_y = init_pos.y + Mathf.Sin(radians) + radius;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * end_x, Mathf.Sin(Time.time) * end_y, 0);
            //init_pos + new Vector3(current_pos.x * Mathf.Sin(Time.time), 0, 0);
        Debug.Log(Mathf.Sin(Time.time));
    }
}
