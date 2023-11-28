using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor_down_col : MonoBehaviour
{
    public static bool floor_col;

    // Start is called before the first frame update
    void Start()
    {
        floor_col = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "move_floor_down")
        {
            Debug.Log("hit");
            floor_col = true;
        }
    }
    //void OnTriggerExit(Collider col)
    //{
    //    if (col.tag == "move_floor_down")
    //    {
    //        Debug.Log("No");
    //    }
    //}
}