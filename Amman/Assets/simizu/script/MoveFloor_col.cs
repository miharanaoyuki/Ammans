using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor_col : MonoBehaviour
{
    public GameObject floor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "move_floor")
        {
            Debug.Log("hit");
            this.gameObject.transform.parent = floor.gameObject.transform;
        }
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "move_floor")
        {
            Debug.Log("No");
            this.gameObject.transform.parent = null;
        }
    }
}