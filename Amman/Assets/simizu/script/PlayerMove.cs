using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection;

    //�A�j���[�V����
    private Animator anim = null;

    public static float MoveSpeed;//�ړ��X�s�[�h�����邽�߂̕ϐ�

    private Vector3 Velocity;//CharacterController�𓮂������߂�Vector3�^�̕ϐ����쐬

    bool W_jump;
    bool A_jump;
    bool S_jump;
    bool D_jump;

    bool WA_jump;
    bool SA_jump;
    bool SD_jump;
    bool WD_jump;

    // Start is called before the first frame update
    void Start()
    {
        //animator�R���|�[�l���g���擾
        anim = gameObject.GetComponent<Animator>();
        //CharacterController���擾
        controller = GetComponent<CharacterController>();

        MoveSpeed = 3.0f;

        
    }
    void Update()
    {
        // �ڒn���Ă���Ȃ�
        if (controller.isGrounded)
        {
            W_jump = false;
            A_jump = false;
            S_jump = false;
            D_jump = false;

            WA_jump = false;
            SA_jump = false;
            SD_jump = false;
            WD_jump = false;

            anim.SetBool("jump", false);
            // �X�y�[�X�L�[�ŃW�����v
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("jump", true);
                // �W�����v�͂�ݒ�
                moveDirection.y = 5;
            }
        }
        else
        {
            //Debug.Log("�O");
            // �d�͌v�Z
            moveDirection.y -= 8 * Time.deltaTime;
        }

        
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)&& WA_jump = false;)
            {
                transform.rotation = Quaternion.Euler(0, 315, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(0, 225, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0, 45, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0, 135, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);//0���Ɍ�����
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(0, 270, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
        
        

        // Cube�𓮂�������
        controller.Move(moveDirection * Time.deltaTime);

        //controller.Move(Velocity * Time.deltaTime);//characterController��Velocity * ���Ԃ̌o�ߕ�������
    }
}