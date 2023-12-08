using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove2 : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection;

    [SerializeField]
    private SoundManager soundManager;

    //アニメーション
    private Animator anim = null;

    public static float MoveSpeed;//移動スピードを入れるための変数

    private Vector3 Velocity;//CharacterControllerを動かすためのVector3型の変数を作成

    bool trampoline;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        //animatorコンポーネントを取得
        anim = gameObject.GetComponent<Animator>();
        //CharacterControllerを取得
        controller = GetComponent<CharacterController>();

        MoveSpeed = 5.0f;

        trampoline = false;
    }
    void Update()
    {
        if (countdown.ready == true)
        {
            // 接地しているなら
            if (controller.isGrounded)
            {
                anim.SetBool("jump", false);
                // スペースキーでジャンプ
                if (Input.GetKey(KeyCode.Space))
                {

                    soundManager.Play("jump");

                    anim.SetBool("jump", true);
                    if (trampoline == true)
                    {
                        // ジャンプ力を設定
                        moveDirection.y = 10;
                    }
                    else
                    {
                        // ジャンプ力を設定
                        moveDirection.y = 5;
                    }

                }
            }
            else
            {
                //Debug.Log("外");
                // 重力計算
                moveDirection.y -= 8 * Time.deltaTime;
            }

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
        // Cubeを動かす処理
        controller.Move(moveDirection * Time.deltaTime);

        //controller.Move(Velocity * Time.deltaTime);//characterControllerをVelocity * 時間の経過分動かす

        EndGame();//ゲームプレイ終了関数
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trampoline")
        {
            Debug.Log("バイバイ");
            trampoline = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "trampoline")
        {
            trampoline = false;
        }
    }

    private void EndGame()
    {
        //Escが押された時
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
        }
    }
}