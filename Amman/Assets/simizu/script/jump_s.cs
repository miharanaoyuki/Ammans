using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_s : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection;
    //�A�j���[�V����
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        //animator�R���|�[�l���g���擾
        anim = gameObject.GetComponent<Animator>();
        // CharacterController���擾
        controller = GetComponent<CharacterController>();
    }
    

    void Update()
    {
        // �ڒn���Ă���Ȃ�
        if (controller.isGrounded)
        {
            anim.SetBool("jump", false);
            // �X�y�[�X�L�[�ŃW�����v
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("jump", true);
                // �W�����v�͂�ݒ�
                moveDirection.y = 5;
            }
        }

        // �d�͌v�Z
        moveDirection.y -= 8 * Time.deltaTime;

        // Cube�𓮂�������
        controller.Move(moveDirection * Time.deltaTime);
    }
}