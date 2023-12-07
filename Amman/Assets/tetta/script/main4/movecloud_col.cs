using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecloud_col : MonoBehaviour
{
    bool hit_check = false;
    bool hit_check2 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hit_check == true)
        {
            this.gameObject.transform.Translate(movecloud.player_x, 0, 0, Space.World);
        }
        if (hit_check2 == true)
        {
            this.gameObject.transform.Translate(movecloud1.player_x, 0, 0, Space.World);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "move_floor")
        {
            Debug.Log("hit");
            hit_check = true;
        }
        if (col.tag == "move_floor2")
        {
            Debug.Log("hit");
            hit_check2 = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "move_floor")
        {
            Debug.Log("No");
            hit_check = false;
        }
        if (col.tag == "move_floor2")
        {
            Debug.Log("No");
            hit_check2 = false;
        }
    }
}
