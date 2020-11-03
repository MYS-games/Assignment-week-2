using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeat : MonoBehaviour
{
    float maxScale = 1f;
    float minScale = 0.5f;
    float ratio;
    int indicator = 1;
    bool isExpand = false;
    // Start is called before the first frame update
    void Start()
    {
        ratio = 0.4f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 maxVec = new Vector3(maxScale, maxScale, maxScale);
        Vector3 minVec = new Vector3(minScale, minScale, minScale);

        if (transform.localScale.x >= maxScale)
        {
            isExpand = true;
            indicator = -1;

        }
        if (transform.localScale.x <= minScale)
        {
            isExpand = false;
            indicator = 1;
        }

        transform.localScale += new Vector3(ratio * indicator, ratio * indicator, ratio * indicator);

    }

}
