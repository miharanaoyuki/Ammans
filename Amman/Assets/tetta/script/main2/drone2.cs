using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone2 : MonoBehaviour
{
    float speed = 0.1f;

    float limit = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(limit > 10 || limit < 0)
        {
            speed *= -1;
        }

        transform.Translate(0, 0, speed);
        limit += speed;
    }
}
