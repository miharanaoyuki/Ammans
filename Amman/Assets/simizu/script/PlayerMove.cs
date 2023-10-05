using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMove : MonoBehaviour
{
    //��������
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        //�O���ړ�
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
        }

        //����ړ�
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
        }

        //�E�ړ�
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * transform.right * Time.deltaTime;
        }

        //���ړ�
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
        }
    }
}
