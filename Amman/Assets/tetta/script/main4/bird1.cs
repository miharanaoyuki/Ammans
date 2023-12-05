using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird1 : MonoBehaviour
{
    public float speed = 0.1f;
    float move = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);
        move += speed;
        if(move > 13f || move < -13f)
        {
            move = 0;
            speed *= -1.0f;
        }
    }
}