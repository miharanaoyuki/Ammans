using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_flymove : MonoBehaviour
{
    //�G�@��GameObject�Ƃ��Đ錾����
    public GameObject circleprefab;
    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        //GenerateCircle()���J�n����
        StartCoroutine("GenerateCircle");
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�G�@(Circle)�𐶐�����
    IEnumerator GenerateCircle()
    {
        while (true)
        {
            Instantiate(
                circleprefab,
                new Vector3(x, y, z),
                transform.rotation
            );
            //�b���ƂɎ��s����B
            yield return new WaitForSeconds(1.0f);
        }
    }

}