using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用

public class Scenenavi : MonoBehaviour
{
    [SerializeField] GameObject panel;
    // 中に記述された処理が一定間隔で繰り返し実行される

    void Update()
    {
        // もし入力したキーがEnterキーならば、中の処理を実行する
        if (Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.Space))
        {

            panel.SetActive(false);
            Build.the_world = false;
        }
    }
   
}