using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D2 : MonoBehaviour
{
    private SpriteRenderer spriteRender;
    bool isActive = true;
    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isActive = !isActive;
        }
        if (isActive)
        {
            spriteRender.enabled = true;
        }
        else
        {
            spriteRender.enabled = false;
        }
    }
}
