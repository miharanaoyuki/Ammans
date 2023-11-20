using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection;

    [SerializeField]
    private SoundManager soundManager;

    //�A�j���[�V����
    private Animator anim = null;

    public static float MoveSpeed;//�ړ��X�s�[�h�����邽�߂̕ϐ�

    private Vector3 Velocity;//CharacterController�𓮂������߂�Vector3�^�̕ϐ����쐬

    bool a, b, c, d, e, f, g, h;

    bool trampoline;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        //animator�R���|�[�l���g���擾
        anim = gameObject.GetComponent<Animator>();
        //CharacterController���擾
        controller = GetComponent<CharacterController>();

        MoveSpeed = 5.0f;

        trampoline = false;
    }
    void Update()
    {
        // �ڒn���Ă���Ȃ�
        if (controller.isGrounded)
        {
            a = false;
            b = false;
            c = false;
            d = false;
            e = false;
            f = false;
            g = false;
            h = false;

            anim.SetBool("jump", false);
            // �X�y�[�X�L�[�ŃW�����v
            if (Input.GetKey(KeyCode.Space))
            {
               
                soundManager.Play("jump");
                
                anim.SetBool("jump", true);
                if(trampoline == true)
                {
                    // �W�����v�͂�ݒ�
                    moveDirection.y = 10;
                }
                else
                {
                    // �W�����v�͂�ݒ�
                    moveDirection.y = 5;
                }
                
            }
        }
        else
        {
            //Debug.Log("�O");
            // �d�͌v�Z
            moveDirection.y -= 8 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) && a == false)
        {
            //cursor = true;
            b = true;
            c = true;
            d = true;
            e = true;
            f = true;
            g = true;
            h = true;
            transform.rotation = Quaternion.Euler(0, 315, 0);
            controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) && b == false)
        {
            a = true;
            //b = true;
            c = true;
            d = true;
            e = true;
            f = true;
            g = true;
            h = true;
            transform.rotation = Quaternion.Euler(0, 225, 0);
            controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && c == false)
        {
            a = true;
            b = true;
            //c = true;
            d = true;
            e = true;
            f = true;
            g = true;
            h = true;
            transform.rotation = Quaternion.Euler(0, 45, 0);
            controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && d == false)
        {
            a = true;
            b = true;
            c = true;
            //d = true;
            e = true;
            f = true;
            g = true;
            h = true;
            transform.rotation = Quaternion.Euler(0, 135, 0);
            controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W) && e == false)
        {
            a = true;
            b = true;
            c = true;
            d = true;
            //e = true;
            f = true;
            g = true;
            h = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);//0���Ɍ�����
            controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) && f == false)
        {
            a = true;
            b = true;
            c = true;
            d = true;
            e = true;
            //f = true;
            g = true;
            h = true;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A) && g == false)
        {
            a = true;
            b = true;
            c = true;
            d = true;
            e = true;
            f = true;
            //g = true;
            h = true;
            transform.rotation = Quaternion.Euler(0, 270, 0);
            controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D) && h == false)
        {
            a = true;
            b = true;
            c = true;
            d = true;
            e = true;
            f = true;
            g = true;
            //h = true;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        
        // Cube�𓮂�������
        controller.Move(moveDirection * Time.deltaTime);

        //controller.Move(Velocity * Time.deltaTime);//characterController��Velocity * ���Ԃ̌o�ߕ�������

        EndGame();//�Q�[���v���C�I���֐�
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trampoline")
        {
            Debug.Log("�o�C�o�C");
            trampoline = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "trampoline")
        {
            trampoline = false;
        }
    }

        private void EndGame()
    {
        //Esc�������ꂽ��
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
        }
    }
}