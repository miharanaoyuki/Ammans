using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour
{
    // Start is called before the first frame update
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
        //上
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
            //anim.SetTrigger("idle");
        }
    }
}
