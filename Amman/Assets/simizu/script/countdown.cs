using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countdown : MonoBehaviour
{
	public static float CountDownTime;    //カウントダウンタイム
	public TextMeshProUGUI TextCountDown; //表示用テキストUI

	public static bool ready;

	// Use this for initialization
	void Start()
	{
		CountDownTime = 3.4f; //カウントダウン開始秒数をセット
		TextCountDown.enabled = true;
		ready = false;
	}

	// Update is called once per frame
	void Update()
	{
		//カウントダウンタイムを整形して表示
		TextCountDown.text = String.Format("{0:0}", CountDownTime);
		//経過時刻を引いていく
		CountDownTime -= Time.deltaTime;

		if (CountDownTime <= 0.5f)
		{
			TextCountDown.text = String.Format("Go!!");
		}

		//0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
		if (CountDownTime <= 0.0f)
		{
			TextCountDown.enabled = false;
			CountDownTime = 0.0f;
			ready = true;
		}
	}
}