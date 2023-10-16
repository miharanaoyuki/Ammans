using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float Speed_Up_cnt;    //どれぐらい速くするか
    public float Speed_Up_Time;   //元のスピードに戻る時間
    public float Speed_Down_cnt;  //どれぐらい遅くするか
    public float Speed_Down_Time; //元のスピードに戻る時間
    public float Speed_Remove;    //元のスピード

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
            PlayerMove.MoveSpeed += Speed_Up_cnt;

            Invoke("Remove", Speed_Up_Time); //〇秒後に"Remove"関数を実行
        }

        //プレイヤーのスピードを遅くする
        if (col.gameObject.tag == "b")
        {
            Destroy(col.gameObject);
            PlayerMove.MoveSpeed -= Speed_Down_cnt;

            Invoke("Remove", Speed_Down_Time);
        }
    }

    void Remove()
    {
        Debug.Log("スピード戻った");
        PlayerMove.MoveSpeed = Speed_Remove; //元に戻す
    }
}
