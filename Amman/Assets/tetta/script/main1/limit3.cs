using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limit3 : MonoBehaviour
{
    float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= -8.0f && camera_move1.point == 2)
        {
            transform.Translate(0, 0, speed);
        }
    }
}
