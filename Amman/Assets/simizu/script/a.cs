using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    public static bool siten;


    // Start is called before the first frame update
    void Start()
    {
        siten = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0);
    }
}
