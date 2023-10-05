using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAnim : MonoBehaviour
{
    //�A�j���[�V����
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animator�R���|�[�l���g���擾
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�O
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("run");
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetTrigger("idle");
        }

        //���
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("run");
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetTrigger("idle");
        }

        //�E
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("run");
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetTrigger("idle");
        }

        //��
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("run");
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetTrigger("idle");
        }

        //�W�����v
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("jump");
        }
        //else if (Input.GetKeyUp(KeyCode.))
        //{
        //    animator.SetTrigger("idle");
        //}
    }
}
