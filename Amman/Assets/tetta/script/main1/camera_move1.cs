using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move1 : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("MaleFree1");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);

        if (playerPos.x < -8)
        {
            transform.position = new Vector3(
                -8, transform.position.y, transform.position.z);
        }

        if (playerPos.x > 8)
        {
            transform.position = new Vector3(
                8, transform.position.y, transform.position.z);
        }
    }
}
