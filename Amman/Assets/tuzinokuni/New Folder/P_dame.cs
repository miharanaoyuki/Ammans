using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class P_dame : MonoBehaviour
{
    /// <summary> モデルのRenderer </summary>
    [SerializeField]
    private Renderer _renderer;

    //点滅コルーチン管理用。
    Coroutine hitBlink;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            StartCoroutine("HitBlink");
        }
       
    }

    /// <summary> 点滅によるダメージ演出再生 </summary>
    private IEnumerator HitBlink()
    {

        //レイヤーをPlayerDamageに変更
        gameObject.layer = 8;
        int count = 20;
        while (count > 0)
        {

            _renderer.enabled = false;
            //0.05秒待つ
            yield return new WaitForSeconds(0.05f);
            _renderer.enabled = true;
            //0.05秒待つ
            yield return new WaitForSeconds(0.05f);
            count--;
        }
        //レイヤーをPlayerに戻す
        gameObject.layer = 6;



    }
}
