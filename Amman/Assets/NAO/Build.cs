using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    [SerializeField] GameObject panel;
   
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
    }

    //void OnTriggerExit(Collision other)
    //{
    //    if (other.gameObject.tag == "door")
    //    {
    //        panel.SetActive(false);
    //    }
    //}
}