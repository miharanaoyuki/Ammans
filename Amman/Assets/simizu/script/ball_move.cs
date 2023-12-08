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

        transform.position += new Vector3(move_x, move_y, move_z) * Time.deltaTime * 2.5f;

        if (pos.x <= 20.0f || pos.x >= 65.0f)
        {
            Destroy(gameObject);
        }
    }
}