using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecloud_col : MonoBehaviour
{
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
            Debug.Log("aaaaa");
            Vector3 pos = transform.position;
            pos.x += movecloud.player_moveX;
            pos.y += movecloud.player_moveY;
            pos.z += movecloud.player_moveZ;
        }
    }
}
