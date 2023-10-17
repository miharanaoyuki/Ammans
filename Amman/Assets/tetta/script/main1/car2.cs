using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car2 : MonoBehaviour
{
    float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 72.0f && camera_move1.point == 1)
        {
            transform.Translate(0, 0, speed);
        }
    }
}
