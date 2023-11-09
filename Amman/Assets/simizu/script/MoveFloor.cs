using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    float x = 0.1f;
    float y = 0.1f;
    float z = 0.1f;
    public float x_move;
    public float y_move;
    public float z_move;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Swith2", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = new Vector3(x, y, z);
        transform.Translate(p);
    }

    void Swith()
    {
        x = x_move;
        y = y_move;
        z = z_move;
        Invoke("Swith2", 1.0f);
    }

    void Swith2()
    {
        x = -x_move;
        y = -y_move;
        z = -z_move;
        Invoke("Swith", 1.0f);
    }
}