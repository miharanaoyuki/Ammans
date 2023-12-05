using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stageselect : MonoBehaviour
{
    
    [SerializeField] GameObject  main2;
    [SerializeField] GameObject  main3;
    [SerializeField] GameObject  main4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (clear_check.clear_check_1 == true)
        { 
            main2.SetActive(true);
        }

        if (clear_check.clear_check_2 == true)
        { 
            main3.SetActive(true);
        }

        if (clear_check.clear_check_3 == true)
        {
            main4.SetActive(true);
        }

    }
}
