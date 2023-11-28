using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI使うときに必要
using UnityEngine.UI;
public class Build : MonoBehaviour
{
    Button button;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject panel2;
    [SerializeField] GameObject panel3;
    [SerializeField] GameObject panel4;

    public static bool the_world;
   
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        
        panel.SetActive(false);
        the_world = false;
    }

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "stage1")
        {
            panel.SetActive(true);
            the_world = true;
            Debug.Log("hit");
        }
    

        if (other.gameObject.tag == "stage2")
        {
            panel2.SetActive(true);
            the_world = true;
            Debug.Log("hit1");
        }


        if (other.gameObject.tag == "stage3")
        {
            panel3.SetActive(true);
            the_world = true;
            Debug.Log("hit2");
        }

        if (other.gameObject.tag == "stage4")
        {
            panel4.SetActive(true);
            the_world = true;
            Debug.Log("hit3");
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "door")
    //    {
    //        Choice.cursor = false;
    //    }
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "door")
    //    {
    //        //ボタンが選択された状態になる
    //        //button.Select();
    //    }

    //}
}