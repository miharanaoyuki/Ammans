using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemnt�̋@�\���g�p

public class Scenenavi : MonoBehaviour
{
    [SerializeField] GameObject panel;
    // ���ɋL�q���ꂽ���������Ԋu�ŌJ��Ԃ����s�����
    [SerializeField]
    private SoundManager soundManager;

        public void OnClickStartButton()
        {
            // �������͂����L�[��Enter�L�[�Ȃ�΁A���̏��������s����
            if (Input.GetKeyDown(KeyCode.Space))
            {

                Invoke("cancel", 0.1f);
            }
        }
    

    void cancel()
    {

        soundManager.Play("cancel");
        Choice.cursor = false;
        panel.SetActive(false);
        Build.the_world = false;
    }



}