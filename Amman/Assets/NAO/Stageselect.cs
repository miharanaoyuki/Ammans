using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stageselect : MonoBehaviour
{
    [SerializeField] GameObject  panel2;
    [SerializeField] GameObject  panel3;
    [SerializeField] GameObject  panel4;
    [SerializeField] GameObject   main2;
    [SerializeField] GameObject   main3;
    [SerializeField] GameObject   main4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (clear_check.clear_check_1 == true)
        {
           panel2.SetActive(true);
            main2.SetActive(true);
        }

        if (clear_check.clear_check_2 == true)
        {
           panel3.SetActive(true);
            main3.SetActive(true);
        }

        if (clear_check.clear_check_3 == true)
        {
           panel4.SetActive(true);
            main4.SetActive(true);
        }

    }
}
