using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class police_move2 : MonoBehaviour
{
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 94 || transform.position.x < 83)
        {
            speed *= -1;
        }

        transform.Translate(speed, 0, 0);
    }
}
