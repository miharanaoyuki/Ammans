using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMove : MonoBehaviour
{
    //��������
    float speed = 3.0f;
    //�A�j���[�V����
    private Animator animator;

    void Start()
    {
        //animator�R���|�[�l���g���擾
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //�O���ړ�
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            
            transform.position += speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("walk");
            //transform.position += speed * transform.forward * Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetTrigger("idle");
        }

        //����ړ�
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
        }

        //�E�ړ�
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += speed * transform.right * Time.deltaTime;
        }

        //���ړ�
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
        }
    }
}
