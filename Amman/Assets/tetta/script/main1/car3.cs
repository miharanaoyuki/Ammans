using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car3 : MonoBehaviour
{
    float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(0, 0, speed);
    }
}
