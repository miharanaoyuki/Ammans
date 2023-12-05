using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ball_move : MonoBehaviour
{
    public float move_x;
    public float move_y;
    public float move_z;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        transform.position += new Vector3(move_x, move_y, move_z) * Time.deltaTime * 2f;

        if (pos.x <= -15.0f)
        {
            Destroy(gameObject);
        }
    }
}