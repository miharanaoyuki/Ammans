using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wake : MonoBehaviour
{
    // ���ɋL�q���ꂽ���������Ԋu�ŌJ��Ԃ����s�����
    void Update()
    {
        
        // �������͂����L�[������Ȃ�΁A���̏��������s����
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("�X�s�[�h�߂���");
            // AudioClip�ɐݒ肵���������Đ�����
            GetComponent<AudioSource>().Play();
        }
       
        // �������͂����L�[�������Ȃ�΁A���̏��������s����
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // AudioClip�ɐݒ肵���������~����
            GetComponent<AudioSource>().Stop();
        }
    }
}
