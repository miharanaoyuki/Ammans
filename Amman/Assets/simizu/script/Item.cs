using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float Speed_Up;        //速くなったスピード
    public float Speed_Up_Time;   //速くなってから元のスピードに戻る時間
    //public float Speed_Down;      //遅くなったスピード
    //public float Speed_Down_Time; //遅くなってから元のスピードに戻る時間
    public float Remove_Speed;    //元のスピード

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
        if (col.gameObject.tag == "speed_UP")
        {
            Destroy(col.gameObject);
            PlayerMove.MoveSpeed = Speed_Up;

            Invoke("Remove", Speed_Up_Time); //〇秒後に"Remove"関数を実行
        }

        //スピードを遅くする
        //if (col.gameObject.tag == "Enemy")
        //{
        //    //Destroy(col.gameObject);
        //    PlayerMove.MoveSpeed = Speed_Down;

        //    Invoke("Remove", Speed_Down_Time);
        //}

        //HP回復
        if (col.gameObject.tag == "heart")
        {
            Destroy(col.gameObject);
            //
        }
    }

    void Remove()
    {
        Debug.Log("スピード戻った");
        PlayerMove.MoveSpeed = Remove_Speed; //元に戻す
    }
}
