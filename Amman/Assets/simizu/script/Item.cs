using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float Speed_Up;        //�����Ȃ����X�s�[�h
    public float Speed_Up_Time;   //�����Ȃ��Ă��猳�̃X�s�[�h�ɖ߂鎞��
    //public float Speed_Down;      //�x���Ȃ����X�s�[�h
    //public float Speed_Down_Time; //�x���Ȃ��Ă��猳�̃X�s�[�h�ɖ߂鎞��
    public float Remove_Speed;    //���̃X�s�[�h

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag); //������������̖��O���擾

        //�v���C���[�̃X�s�[�h�𑬂�����
        if (col.gameObject.tag == "speed_UP")
        {
            Destroy(col.gameObject);
            PlayerMove.MoveSpeed = Speed_Up;

            Invoke("Remove", Speed_Up_Time); //�Z�b���"Remove"�֐������s
        }

        //�X�s�[�h��x������
        //if (col.gameObject.tag == "Enemy")
        //{
        //    //Destroy(col.gameObject);
        //    PlayerMove.MoveSpeed = Speed_Down;

        //    Invoke("Remove", Speed_Down_Time);
        //}

        //HP��
        if (col.gameObject.tag == "heart")
        {
            Destroy(col.gameObject);
            //
        }
    }

    void Remove()
    {
        Debug.Log("�X�s�[�h�߂���");
        PlayerMove.MoveSpeed = Remove_Speed; //���ɖ߂�
    }
}
