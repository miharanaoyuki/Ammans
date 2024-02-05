using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotateCube : MonoBehaviour
{
    int  ver  = -90;
    bool Hit  = false;
    bool stop = false;
    [SerializeField]
    private SoundManager soundManager;

    void Update()
    {
        if (Hit == true)
        {
            
            transform.Rotate(new Vector3(3, 0, 0));

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "death")
        {
            if (stop == false)
            {
                soundManager.Play("robo");
                stop = true;
            }
            Hit = true;
        }
    }
}
