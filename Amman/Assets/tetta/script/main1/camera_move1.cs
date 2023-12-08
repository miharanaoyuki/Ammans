using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move1 : MonoBehaviour
{
    float speed = 0.05f;

    public static int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown.ready == true)
        {
            if (point == 0)
            {
                transform.Translate(0, 0, speed);
            }
            if (transform.position.z >= 64.0f && transform.position.x <= 1.0f)
            {
                point = 1;
            }
            if (point == 1)
            {
                transform.Translate(speed, 0, 0);
            }
            if (transform.position.x >= 88.9f)
            {
                point = 2;
            }
            if (point == 2)
            {
                transform.Translate(0, 0, -speed);
            }
        }
    }
}
