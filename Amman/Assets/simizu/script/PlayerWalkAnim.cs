using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAnim : MonoBehaviour
{
    //アニメーション
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        //animatorコンポーネントを取得
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //左上
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            anim.SetBool("run2", true);
        }
        //右上
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            anim.SetBool("run2", true);
        }
        //左下
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            anim.SetBool("run2", true);
        }
        //右下
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            anim.SetBool("run2", true);
        }
        //前
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("run2", true);
        }
        //後ろ
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("run2", true);
        }
        //右
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("run2", true);
        }
        //左
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("run2", true);
        }
        //何もしない場合
        else
        {
            anim.SetBool("run2", false);
            //anim.SetTrigger("idle");
        }

        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || 
            Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            && Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("run2", false);
        }
    }
}
