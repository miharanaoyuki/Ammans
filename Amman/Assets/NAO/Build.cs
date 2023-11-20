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