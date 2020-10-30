using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Tooltip("move")]
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    float radius;
   

    float end_x, start_x, init_start;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        /*  if (start_x == null || end_x == null)
          {
              start_x = transform.position.x - radius;
              end_x = transform.position.x + radius;
          }
          */
        start_x = transform.position.x - radius;
        end_x = transform.position.x + radius;
        init_start = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.x <= (start_x + 1))
        {
            direction = 1;
        }
        if (transform.position.x >= (end_x - 1))
        {
            direction = -1;
        }
       
        speed = radius - Math.Abs(init_start - transform.position.x + 0.2f);
        transform.position += new Vector3((direction * speed) * Time.deltaTime , 0, 0);
    }
}
