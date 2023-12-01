using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        //animator�R���|�[�l���g���擾
        anim = gameObject.GetComponent<Animator>();
        //CharacterController���擾
        controller = GetComponent<CharacterController>();

        MoveSpeed = 5.0f;
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

            //if (Build.the_world == false)
            //{
            //    anim.SetBool("jump", false);
            //    // �X�y�[�X�L�[�ŃW�����v
            //    if (Input.GetKey(KeyCode.Space))
            //    {

            //        soundManager.Play("jump");

            //        anim.SetBool("jump", true);
            //        // �W�����v�͂�ݒ�
            //        moveDirection.y = 5;
            //    }
            //}
        }
        else
        {
            //Debug.Log("�O");
            // �d�͌v�Z
            moveDirection.y -= 8 * Time.deltaTime;
        }

        if (Build.the_world == false)
        {
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W) && a == false)
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
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) && b == false)
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
            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && c == false)
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
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) && d == false)
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
            else if (Input.GetKey(KeyCode.D) && e == false)
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
            else if (Input.GetKey(KeyCode.A) && f == false)
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
            else if (Input.GetKey(KeyCode.W) && g == false)
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
            else if (Input.GetKey(KeyCode.S) && h == false)
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
        }
        // Cube�𓮂�������
        controller.Move(moveDirection * Time.deltaTime);

        //controller.Move(Velocity * Time.deltaTime);//characterController��Velocity * ���Ԃ̌o�ߕ�������

        //�J�������_-------------------------------------------------------------------------------------
        Vector3 pos = transform.position;
        if (pos.z > 10.0f)
        {
            siten.siten_sousa = true;
        }
        else
        {
            siten.siten_sousa = false;
        }
        //-----------------------------------------------------------------------------------------------

        EndGame();//�Q�[���v���C�I���֐�
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