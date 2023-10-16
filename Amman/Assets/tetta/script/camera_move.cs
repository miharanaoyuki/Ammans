using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    //スピード
    float speed = 0.01f;
    //ポイントまで行くと動きを変える
    int Point = 0;

    void Update()
    {
        if(transform.position.z >= 87.5f && Point == 0)
        {
            Point = 1;
        }
        if(transform.position.x >= 88.7f && Point == 1)
        {
            Point = 2;
        }
        if (transform.position.z <= 15.0f && Point == 2)
        {
            Point = 3;
        }

        if (Point == 0)
        {
            transform.Translate(0, 0, speed);
        }
        if(Point == 1)
        {
            transform.Translate(speed, 0, 0);
        }
        if (Point == 2)
        {
            transform.Translate(0, 0, -speed);
        }
    }
}