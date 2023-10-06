using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_s : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection;
    //アニメーション
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        //animatorコンポーネントを取得
        anim = gameObject.GetComponent<Animator>();
        // CharacterControllerを取得
        controller = GetComponent<CharacterController>();
    }
    

    void Update()
    {
        // 接地しているなら
        if (controller.isGrounded)
        {
            anim.SetBool("jump", false);
            // スペースキーでジャンプ
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("jump", true);
                // ジャンプ力を設定
                moveDirection.y = 5;
            }
        }

        // 重力計算
        moveDirection.y -= 8 * Time.deltaTime;

        // Cubeを動かす処理
        controller.Move(moveDirection * Time.deltaTime);
    }
}