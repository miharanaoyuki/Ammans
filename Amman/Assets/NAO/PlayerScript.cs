using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection;

    [SerializeField]
    private SoundManager soundManager;

    //アニメーション
    private Animator anim = null;

    public static float MoveSpeed;//移動スピードを入れるための変数

    private Vector3 Velocity;//CharacterControllerを動かすためのVector3型の変数を作成

    bool a, b, c, d, e, f, g, h;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        //animatorコンポーネントを取得
        anim = gameObject.GetComponent<Animator>();
        //CharacterControllerを取得
        controller = GetComponent<CharacterController>();

        MoveSpeed = 5.0f;
    }
    void Update()
    {
        // 接地しているなら
        if (controller.isGrounded)
        {
            a = false;
            b = false;
            c = false;
            d = false;
            e = false;
            f = false;
            g = false;
            h = false;

            //if (Build.the_world == false)
            //{
            //    anim.SetBool("jump", false);
            //    // スペースキーでジャンプ
            //    if (Input.GetKey(KeyCode.Space))
            //    {

            //        soundManager.Play("jump");

            //        anim.SetBool("jump", true);
            //        // ジャンプ力を設定
            //        moveDirection.y = 5;
            //    }
            //}
        }
        else
        {
            //Debug.Log("外");
            // 重力計算
            moveDirection.y -= 8 * Time.deltaTime;
        }

        if (Build.the_world == false)
        {
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W) && a == false)
            {
                //cursor = true;
                b = true;
                c = true;
                d = true;
                e = true;
                f = true;
                g = true;
                h = true;
                transform.rotation = Quaternion.Euler(0, 315, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) && b == false)
            {
                a = true;
                //b = true;
                c = true;
                d = true;
                e = true;
                f = true;
                g = true;
                h = true;
                transform.rotation = Quaternion.Euler(0, 225, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && c == false)
            {
                a = true;
                b = true;
                //c = true;
                d = true;
                e = true;
                f = true;
                g = true;
                h = true;
                transform.rotation = Quaternion.Euler(0, 45, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) && d == false)
            {
                a = true;
                b = true;
                c = true;
                //d = true;
                e = true;
                f = true;
                g = true;
                h = true;
                transform.rotation = Quaternion.Euler(0, 135, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D) && e == false)
            {
                a = true;
                b = true;
                c = true;
                d = true;
                //e = true;
                f = true;
                g = true;
                h = true;
                transform.rotation = Quaternion.Euler(0, 0, 0);//0°に向ける
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A) && f == false)
            {
                a = true;
                b = true;
                c = true;
                d = true;
                e = true;
                //f = true;
                g = true;
                h = true;
                transform.rotation = Quaternion.Euler(0, 180, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W) && g == false)
            {
                a = true;
                b = true;
                c = true;
                d = true;
                e = true;
                f = true;
                //g = true;
                h = true;
                transform.rotation = Quaternion.Euler(0, 270, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && h == false)
            {
                a = true;
                b = true;
                c = true;
                d = true;
                e = true;
                f = true;
                g = true;
                //h = true;
                transform.rotation = Quaternion.Euler(0, 90, 0);
                controller.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
            }
        }
        // Cubeを動かす処理
        controller.Move(moveDirection * Time.deltaTime);

        //controller.Move(Velocity * Time.deltaTime);//characterControllerをVelocity * 時間の経過分動かす

        //カメラ視点-------------------------------------------------------------------------------------
        Vector3 pos = transform.position;
        if (pos.z > 10.0f)
        {
            siten.siten_sousa = true;
        }
        else
        {
            siten.siten_sousa = false;
        }
        //-----------------------------------------------------------------------------------------------

        EndGame();//ゲームプレイ終了関数
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