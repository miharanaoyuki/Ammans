using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection;

    void Start()
    {
        // CharacterController���擾
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // �ڒn���Ă���Ȃ�
        if (controller.isGrounded)
        {
            // �X�y�[�X�L�[�ŃW�����v
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // �W�����v�͂�ݒ�
                moveDirection.y = 5;
            }
        }

        // �d�͌v�Z
        moveDirection.y -=8 * Time.deltaTime;

        // Cube�𓮂�������
        controller.Move(moveDirection * Time.deltaTime);
    }
}