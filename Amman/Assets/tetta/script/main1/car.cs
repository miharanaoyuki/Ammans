using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown.ready == true)
        {
            if (camera_move1.point == 0)
            {
                transform.Translate(0, 0, speed);
            }
        }
    }
}
