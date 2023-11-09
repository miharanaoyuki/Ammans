using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public static int life = 3;//hpを6にする。SliderのMaxValueとValueはここの値に合わせます
    private Slider _slider;//Sliderの値を代入する_sliderを宣言
    public GameObject slider;//体力ゲージに指定するSlider
    public static int maxHp = 3;


    public static int MAX = 3;

    public GameObject[] lifeArray = new GameObject[3];
    private int lifePoint = 3;

    [SerializeField]
    private SoundManager soundManager;
    //[SerializeField]
    //private SoundManager soundManager;
    // Use this for initialization
    void Start()
    {
        life = maxHp;
        //Debug.Log(life);

        _slider = slider.GetComponent<Slider>();//sliderを取得する
    }

    // Update is called once per frame
    void Update()
    {


        _slider.maxValue = maxHp;

        //スライダーの現在値の設定



        _slider.value = life;


       
        if (life <= 0)
        {

            life = MAX;

            lifeArray[0].SetActive(true);
            lifeArray[1].SetActive(true);
            lifeArray[2].SetActive(true);
            die();
        }


    }

    void die()
    {

        SceneManager.LoadScene("GAMEOVER");

        //Debug.Log("バイバイ");

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("バイバイ");
            soundManager.Play("damage");

            soundManager.Play("dame");
            lifeArray[life - 1].SetActive(false);
            life--;
        }

        if (other.gameObject.tag == "heart")
        {
            Debug.Log("バイ");
            soundManager.Play("damage");

            if (life < 3)
            {
                soundManager.Play("Heal");
                lifeArray[life].SetActive(true);
                life++;
            }
        }


        if (other.gameObject.tag == "death")
        {
            SceneManager.LoadScene("GAMEOVER");

        }
        if (other.gameObject.tag == "clear")
        {
            SceneManager.LoadScene("GameClear");

        }

    }

    void OnCollisionEnter(Collision col)
    {


        Debug.Log("バp");



    }

}
