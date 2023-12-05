using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_flymove : MonoBehaviour
{
    //敵機をGameObjectとして宣言する
    public GameObject circleprefab;
    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        //GenerateCircle()を開始する
        StartCoroutine("GenerateCircle");
    }

    // Update is called once per frame
    void Update()
    {

    }

    //敵機(Circle)を生成する
    IEnumerator GenerateCircle()
    {
        while (true)
        {
            Instantiate(
                circleprefab,
                new Vector3(x, y, z),
                transform.rotation
            );
            //秒ごとに実行する。
            yield return new WaitForSeconds(1.0f);
        }
    }

}