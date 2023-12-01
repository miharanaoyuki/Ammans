using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecloud : MonoBehaviour
{
    float x = 0.06f;

    public static float player_x;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Swith2", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = new Vector3(x, 0, 0);
        transform.Translate(p);

        if(x < 0)
        {
            player_x = x - 0.01f;
        }
        if (x > 0)
        {
            player_x = x + 0.01f;
        } 
    }

    void Swith()
    {
        x *= -1.0f;
        Invoke("Swith2", 3.0f);
    }

    void Swith2()
    {
        x *= -1.0f;

        Invoke("Swith", 3.0f);
    }
}
