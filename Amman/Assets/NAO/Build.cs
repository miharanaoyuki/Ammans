using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
   
    [SerializeField] GameObject panel;
    [SerializeField] GameObject panel2;
    public static bool the_world;
   
    void Start()
    {
        panel.SetActive(false);
        the_world = false;
    }

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "door")
        {
            panel.SetActive(true);
            the_world = true;
            Debug.Log("hit");
        }
    

        if (other.gameObject.tag == "door2")
        {
            panel2.SetActive(true);
            the_world = true;
            Debug.Log("hit");
        }
    }

    //    void OnTriggerExit(Collider other)
    //    {
    //        if (other.gameObject.tag == "door")
    //        {
    //            panel.SetActive(false);
    //　　　　　　the_world = false;
//        }

//    }
}