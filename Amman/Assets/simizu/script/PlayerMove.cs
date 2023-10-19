using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection;

    //アニメーション
    private Animator anim = null;

    public static float MoveSpeed;//移動スピードを入れるための変数

    private Vector3 Velocity;//CharacterControllerを動かすためのVector3型の変数を作成

    bool W_jump;
    bool A_jump;
    bool S_jump;
    bool D_jump;

    bool WA_jump;
    bool SA_jump;
    bool SD_jump;
    bool WD_jump;

    // Start is called before the first frame update
    void Start()
    {
        //animatorコンポーネントを取得
        anim = gameObject.GetComponent<Animator>();
        //CharacterControllerを取得
        controller = GetComponent<CharacterController>();

        MoveSpeed = 3.0f;

        
    }
    void Update()
    {
        // 接地しているなら
        if (controller.isGrounded)
        {
            W_jump = false;
            A_jump = false;
            S_jump = false;
            D_jump = false;

            WA_jump = false;
            SA_jump = false;
            SD_jump = false;
            WD_jump = false;

            anim.SetBool("jump", false);
            // スペースキーでジャンプ
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("jump", true);
                // ジャンプ力を設定
                moveDirection.y = 5;
            }
        }
        else
        {
            //Debug.Log("外");
            // 重力計算
            moveDirection.y -= 8 * Time.deltaTime;
        }

        
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)&& WA_jump = false;)
            {
                transform.rotation = Quaternion.Euler(0, 315, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(0, 225, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0, 45, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0, 135, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);//0°に向ける
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(0, 270, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
        
        

        // Cubeを動かす処理
        controller.Move(moveDirection * Time.deltaTime);

        //controller.Move(Velocity * Time.deltaTime);//characterControllerをVelocity * 時間の経過分動かす
    }
}