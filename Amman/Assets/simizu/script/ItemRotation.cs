using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    public bool rotate;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
    }
}
