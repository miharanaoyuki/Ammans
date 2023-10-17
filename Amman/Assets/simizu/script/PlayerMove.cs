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

    bool _jump;

    // Start is called before the first frame update
    void Start()
    {
        //animatorコンポーネントを取得
        anim = gameObject.GetComponent<Animator>();
        //CharacterControllerを取得
        controller = GetComponent<CharacterController>();

        MoveSpeed = 3.0f;

        _jump = false;
    }
    void Update()
    {
        // 接地しているなら
        if (controller.isGrounded)
        {
            _jump = false;
            anim.SetBool("jump", false);
            Debug.Log(_jump);
            // スペースキーでジャンプ
            if (Input.GetKey(KeyCode.Space))
            {
                _jump = true;
                Debug.Log(_jump);
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

        if (_jump == false)
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
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
        }
        else
        {
            controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }

        // Cubeを動かす処理
        controller.Move(moveDirection * Time.deltaTime);

        //controller.Move(Velocity * Time.deltaTime);//characterControllerをVelocity * 時間の経過分動かす
    }
}