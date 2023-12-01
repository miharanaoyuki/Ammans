using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecloud_col : MonoBehaviour
{
    bool hit_check = false;

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
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "move_floor")
        {
            Debug.Log("hit");
            hit_check = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "move_floor")
        {
            Debug.Log("No");
            hit_check = false;
        }
    }
}
