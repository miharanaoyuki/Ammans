using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move4 : MonoBehaviour
{
    float speed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown.ready == true)
        transform.Translate(0, 0, speed);
    }
}
