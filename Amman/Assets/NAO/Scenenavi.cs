using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemnt�̋@�\���g�p

public class Scenenavi : MonoBehaviour
{
    [SerializeField] GameObject panel;
    // ���ɋL�q���ꂽ���������Ԋu�ŌJ��Ԃ����s�����

    void Update()
    {
        // �������͂����L�[��Enter�L�[�Ȃ�΁A���̏��������s����
        if (Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.Space))
        {

            panel.SetActive(false);
            Build.the_world = false;
        }
    }
   
}