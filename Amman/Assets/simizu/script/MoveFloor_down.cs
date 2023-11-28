using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor_down : MonoBehaviour
{
    float z = 0.1f;
    float y = 0f;
    private bool floor_col;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Swith2", 0f);
        floor_col = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (floor_col == true)
        {
            Vector3 p = new Vector3(0, y, z);
            transform.Translate(p);

            Invoke("Swith3", 2f);
            Invoke("Swith4", 2.3f);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            floor_col = true;
        }
    }

    void Swith()
    {
        z = 0.1f; 
        Invoke("Swith2", 0.1f);
    }

    void Swith2()
    {
        z = -0.1f;
        Invoke("Swith", 0.1f);
    }

    void Swith3()
    {
        z = 0f;
    }

    void Swith4()
    {
        y -= 0.001f;
    }
}