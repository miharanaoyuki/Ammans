using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    float speed = 0.0001f;

    void Update()
    {

        transform.Translate(0, 0, speed);

    }
}