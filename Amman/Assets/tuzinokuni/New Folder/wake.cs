using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wake : MonoBehaviour
{
    // 中に記述された処理が一定間隔で繰り返し実行される
    void Update()
    {
        
        // もし入力したキーが上矢印ならば、中の処理を実行する
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("スピード戻った");
            // AudioClipに設定した音源を再生する
            GetComponent<AudioSource>().Play();
        }
       
        // もし入力したキーが下矢印ならば、中の処理を実行する
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // AudioClipに設定した音源を停止する
            GetComponent<AudioSource>().Stop();
        }
    }
}
