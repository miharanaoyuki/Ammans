using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone3 : MonoBehaviour
{
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 14 || transform.position.x < -13)
        {
            speed *= -1;
        }

        transform.Translate(speed, 0, 0);   
    }
}
