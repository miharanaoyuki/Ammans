using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用

public class ToSampleScene : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    // 中に記述された処理が一定間隔で繰り返し実行される
    void Update()
    {
        // もし入力したキーがSpaceキーならば、中の処理を実行する
        if (Input.GetKeyDown(KeyCode.Space))
        {
            soundManager.Play("decision");
            Invoke("scene", 0.6f);
           
        }
    }
    void scene()
    {

        // SampleSceneに切り替える
        SceneManager.LoadScene("StageSelect");
    }
}

