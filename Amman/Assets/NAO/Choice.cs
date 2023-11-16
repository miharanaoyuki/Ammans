using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI使うときに必要
using UnityEngine.UI;
public class Choice : MonoBehaviour
{
    [SerializeField] GameObject panel;
    Button button;
void Start()
{
button = gameObject.GetComponent<Button>();
//ボタンが選択された状態になる
        button.Select();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            panel.SetActive(false);
            Build.the_world = false;
        }
    }
}