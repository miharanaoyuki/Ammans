using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float Speed_Up_cnt;    //�ǂꂮ�炢�������邩
    public float Speed_Up_Time;   //���̃X�s�[�h�ɖ߂鎞��
    public float Speed_Down_cnt;  //�ǂꂮ�炢�x�����邩
    public float Speed_Down_Time; //���̃X�s�[�h�ɖ߂鎞��
    public float Speed_Remove;    //���̃X�s�[�h

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
        if (col.gameObject.tag == "heart")
        {
            Destroy(col.gameObject);
            PlayerMove.MoveSpeed += Speed_Up_cnt;

            Invoke("Remove", Speed_Up_Time); //�Z�b���"Remove"�֐������s
        }

        //�v���C���[�̃X�s�[�h��x������
        if (col.gameObject.tag == "b")
        {
            Destroy(col.gameObject);
            PlayerMove.MoveSpeed -= Speed_Down_cnt;

            Invoke("Remove", Speed_Down_Time);
        }
    }

    void Remove()
    {
        Debug.Log("�X�s�[�h�߂���");
        PlayerMove.MoveSpeed = Speed_Remove; //���ɖ߂�
    }
}
