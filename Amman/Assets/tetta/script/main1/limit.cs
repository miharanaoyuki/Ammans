using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limit : MonoBehaviour
{
    float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= 82.0f)
        {
            transform.Translate(0, 0, speed);
        }
    }
}
