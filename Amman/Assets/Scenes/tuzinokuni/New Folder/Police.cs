using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour
{
    // Start is called before the first frame update
    //�A�j���[�V����
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        //animator�R���|�[�l���g���擾
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //��
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
