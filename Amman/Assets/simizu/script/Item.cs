using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag); //������������̖��O���擾

        //�v���C���[�̃X�s�[�h�𑬂�����
        if (col.gameObject.tag == "heart")
        {
            Destroy(col.gameObject);
            PlayerMove.MoveSpeed += 3.0f;
        }

        //2�i�W�����v
        if (col.gameObject.tag == "b")
        {
            Destroy(col.gameObject);
            //
        }
    }
}
