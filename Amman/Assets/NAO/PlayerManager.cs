using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("stage1"))
        {
            SceneManager.LoadScene("main");
        }

        if (other.gameObject.CompareTag("stage2"))
        {
            SceneManager.LoadScene("main2");
        }

        if (other.gameObject.CompareTag("stage3"))
        {
            SceneManager.LoadScene("main 3");
        } 

        if (other.gameObject.CompareTag("stage4"))
        {
            SceneManager.LoadScene("main4");
        }
    }
}


