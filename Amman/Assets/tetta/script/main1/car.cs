using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float speed = 0.01f;
    float move = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (countdown.ready == true)
        {
            transform.Translate(0, speed, 0);
            move += speed;
            if (move > 0.04f || move < -0.04f)
            {
                move = 0;
                speed *= -1.0f;
            }
        }
    }
}
