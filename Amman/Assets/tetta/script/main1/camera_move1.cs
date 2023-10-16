using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move1 : MonoBehaviour
{
    float speed = 0.01f;
    int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 87.5f && point == 0)
        {
            point = 1;
        }
        if (transform.position.x >= 88.7f && point == 1)
        {
            point = 2;
        }

        if (point == 0)
        {
            transform.Translate(0, 0, speed);
        }
        if (point == 1)
        {
            transform.Translate(speed, 0, 0);
        }
        if (point == 2)
        {
            transform.Translate(0, 0, -speed);
        }
    }
}
