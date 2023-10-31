using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject panel2;
   
    void Start()
    {
        panel.SetActive(false);
    }

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "door")
        {
            panel.SetActive(true);
            Debug.Log("hit");
        }

  if (other.gameObject.tag == "door2")
        {
            panel2.SetActive(true);
            Debug.Log("hit");
        }
    }

    //void OnTriggerExit(Collision other)
    //{
    //    if (other.gameObject.tag == "door")
    //    {
    //        panel.SetActive(false);
    //    }
    //}
}