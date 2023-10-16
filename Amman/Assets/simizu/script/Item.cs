using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
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
        Debug.Log(col.gameObject.tag); //当たった相手の名前を取得

        //プレイヤーのスピードを速くする
        if (col.gameObject.tag == "heart")
        {
            Destroy(col.gameObject);
            PlayerMove.MoveSpeed += 3.0f;
        }

        //2段ジャンプ
        if (col.gameObject.tag == "b")
        {
            Destroy(col.gameObject);
            //
        }
    }
}
