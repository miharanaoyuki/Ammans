using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMove : MonoBehaviour
{
    //アニメーション
    private Animator animator;
    //歩く速さ
    float speed = 3.0f;

    void Start()
    {
        // animatorコンポーネントを取得
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //前方移動
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetTrigger("walk");
            transform.position += speed * transform.forward * Time.deltaTime;
        }

        //後方移動
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
        }

        //右移動
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += speed * transform.right * Time.deltaTime;
        }

        //左移動
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
        }
    }
}
