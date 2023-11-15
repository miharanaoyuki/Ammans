using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour
{

    bool floor_touch; //床に触れたかの判定
    public float downSpeed; //落ちるスピード
    public float fallCount; //床が落ちるまでの時間
    Rigidbody rb; //Rigidbodyの宣言

    // ゲーム開始
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Rigidbodyの取得
        fallCount = 0; //fallCountを初期化
    }

    //更新処理
    void Update()
    {
        //床に触れたら
        if (floor_touch == true)
        {
            //fallCountを1秒ずつ増やす。
            fallCount += Time.deltaTime;
           
            //DownStart関数を使う
            DownStart();
            
        }

    }

    //当たり判定
     void OnCollisionEnter(Collision col)
    {
        Debug.Log("hit2");
        //プレイヤータグが付いているオブジェクトに当たったら
        if (col.gameObject.tag == "Player")
        {
         
            fallCount = 0; //fallCountを初期化
            floor_touch = true; //floor_touchをtrueにする。
           
        }
    }

    //数秒後に床が落ちる
    void DownStart()
    {
        //fallCountが何秒かたったら
        if (fallCount >= 1.0f)
        {
            //isKinematicをオフにする
            rb.isKinematic = false;
        }
    }

};