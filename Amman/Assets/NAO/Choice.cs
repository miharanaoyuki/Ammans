using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI使うときに必要
using UnityEngine.UI;
public class Choice : MonoBehaviour
{
    [SerializeField] GameObject panel;
    Button button;
    public static bool cursor = false;
  void Start()
  {
        cursor = false;
  }

    void Update()
    {
        if (cursor == false)
        {
            button = gameObject.GetComponent<Button>();
            //ボタンが選択された状態になる
            button.Select();
            cursor = true;
        }
    }
}