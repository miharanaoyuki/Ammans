using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countdown : MonoBehaviour
{
	public static float CountDownTime;    //�J�E���g�_�E���^�C��
	public TextMeshProUGUI TextCountDown; //�\���p�e�L�X�gUI

	public static bool ready;

	// Use this for initialization
	void Start()
	{
		CountDownTime = 3.4f; //�J�E���g�_�E���J�n�b�����Z�b�g
		TextCountDown.enabled = true;
		ready = false;
	}

	// Update is called once per frame
	void Update()
	{
		//�J�E���g�_�E���^�C���𐮌`���ĕ\��
		TextCountDown.text = String.Format("{0:0}", CountDownTime);
		//�o�ߎ����������Ă���
		CountDownTime -= Time.deltaTime;

		if (CountDownTime <= 0.5f)
		{
			TextCountDown.text = String.Format("Go!!");
		}

		//0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�i�~�܂����悤�Ɍ�����j
		if (CountDownTime <= 0.0f)
		{
			TextCountDown.enabled = false;
			CountDownTime = 0.0f;
			ready = true;
		}
	}
}