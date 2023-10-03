using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAnim : MonoBehaviour
{
    //�A�j���[�V����
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animator�R���|�[�l���g���擾
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("walk");
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetTrigger("idle");
        }
    }
}
