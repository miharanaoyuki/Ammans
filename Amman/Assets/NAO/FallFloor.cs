using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour
{

    bool floor_touch; //���ɐG�ꂽ���̔���
    public float downSpeed; //������X�s�[�h
    public float fallCount; //����������܂ł̎���
    Rigidbody rb; //Rigidbody�̐錾

    // �Q�[���J�n
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Rigidbody�̎擾
        fallCount = 0; //fallCount��������
    }

    //�X�V����
    void Update()
    {
        //���ɐG�ꂽ��
        if (floor_touch == true)
        {
            //fallCount��1�b�����₷�B
            fallCount += Time.deltaTime;
           
            //DownStart�֐����g��
            DownStart();
            
        }

    }

    //�����蔻��
     void OnCollisionEnter(Collision col)
    {
        Debug.Log("hit2");
        //�v���C���[�^�O���t���Ă���I�u�W�F�N�g�ɓ���������
        if (col.gameObject.tag == "Player")
        {
         
            fallCount = 0; //fallCount��������
            floor_touch = true; //floor_touch��true�ɂ���B
           
        }
    }

    //���b��ɏ���������
    void DownStart()
    {
        //fallCount�����b����������
        if (fallCount >= 1.0f)
        {
            //isKinematic���I�t�ɂ���
            rb.isKinematic = false;
        }
    }

};