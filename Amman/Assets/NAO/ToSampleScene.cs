using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemnt�̋@�\���g�p

public class ToSampleScene : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    // ���ɋL�q���ꂽ���������Ԋu�ŌJ��Ԃ����s�����
    void Update()
    {
        // �������͂����L�[��Space�L�[�Ȃ�΁A���̏��������s����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            soundManager.Play("decision");
            Invoke("scene", 0.6f);
           
        }
    }
    void scene()
    {

        // SampleScene�ɐ؂�ւ���
        SceneManager.LoadScene("StageSelect");
    }
}

