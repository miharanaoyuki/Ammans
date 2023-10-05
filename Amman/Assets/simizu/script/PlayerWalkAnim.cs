using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAnim : MonoBehaviour
{
    //アニメーション
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animatorコンポーネントを取得
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //前
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("run");
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetTrigger("idle");
        }

        //後ろ
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("run");
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetTrigger("idle");
        }

        //右
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("run");
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetTrigger("idle");
        }

        //左
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("run");
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetTrigger("idle");
        }

        //ジャンプ
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("jump");
        }
        //else if (Input.GetKeyUp(KeyCode.))
        //{
        //    animator.SetTrigger("idle");
        //}
    }
}
