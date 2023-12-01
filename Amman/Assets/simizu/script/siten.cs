using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siten : MonoBehaviour
{
    public static bool siten_sousa;

    // Start is called before the first frame update
    void Start()
    {
        siten_sousa = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (siten_sousa == false)
        {
            Debug.Log(siten.siten_sousa);
            pos.z = -1.7f;
        }

        if (siten_sousa == true)
        {
            Debug.Log(siten.siten_sousa);
            pos.z = 17.5f;
        }

        transform.position = pos;
    }
}
