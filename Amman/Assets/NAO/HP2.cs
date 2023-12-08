using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP2 : MonoBehaviour
{
    public static int life = 3;//hpを6にする。SliderのMaxValueとValueはここの値に合わせます

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


    }

    // Update is called once per frame
    void Update()
    {
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
        Debug.Log("バイバイ");
        SceneManager.LoadScene("Gameover2");



    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            soundManager.Play("damage");

            soundManager.Play("dame");
            lifeArray[life - 1].SetActive(false);
            life--;
        }

        if (other.gameObject.tag == "heart")
        {

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
            SceneManager.LoadScene("Gameover2");

        }
    }

    void OnCollisionEnter(Collision col)
    {






    }

}
