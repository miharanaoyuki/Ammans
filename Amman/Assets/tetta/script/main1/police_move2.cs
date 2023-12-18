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
        if (transform.position.x > 94)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        if (transform.position.x < 83)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        transform.Translate(0, 0, speed);
    }
}
