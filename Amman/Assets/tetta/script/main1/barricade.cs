using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barricade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        myTransform.Rotate(0.1f, 0f, 0f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "barricade")
        {
            
            //transform.Rotate(90f, 0f, 0f);  // Zé≤Ç10ÅãâÒì]
            gameObject.layer = LayerMask.NameToLayer("Default");
            
        }
    }
}
