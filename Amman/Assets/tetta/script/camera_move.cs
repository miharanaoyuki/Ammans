using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    float speed = 0.01f;

    void Update()
    {

        transform.Translate(0, 0, speed);

    }
}