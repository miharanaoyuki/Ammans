using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear_check : MonoBehaviour
{
    public static bool clear_check_1;
    public static bool clear_check_2;
    public static bool clear_check_3;
    public static bool clear_check_4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "clear")
        {
            clear_check_1 = true;
            SceneManager.LoadScene("GameClear");
        }
        if (other.gameObject.tag == "clear2")
        {
            clear_check_2 = true;
            SceneManager.LoadScene("GameClear");
        }
        if (other.gameObject.tag == "clear3")
        {
            clear_check_3 = true;
            SceneManager.LoadScene("GameClear3");
        }
        if (other.gameObject.tag == "clear4")
        {
            clear_check_4 = true;
            SceneManager.LoadScene("GameClear");
        }
    }
}
