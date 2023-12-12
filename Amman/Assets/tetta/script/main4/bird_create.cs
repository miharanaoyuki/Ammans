using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_create : MonoBehaviour
{
	public GameObject bullet; //���v���n�u�FInspector�Ŏw��
	public float intervalSec = 2; //�쐬�Ԋu�i�b�j�FInspector�Ŏw�肷��
								  //public AudioClip bossbulletsou;

	Transform tf; //�G��Transform

	void Start()
	{
		//Debug.Log(attack_flag);

		//�w��b���
		Invoke("CreatePrefab2", intervalSec);
	}

	void Update()
	{

	}

	void CreatePrefab()
	{

		//���̃I�u�W�F�N�g�͈͓̔��Ƀ����_����
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		Vector3 newPos = this.transform.position;
		newPos.x = 2.5f;
		newPos.y = 0;
		newPos.z = 191; //��O�ɕ\��

		//�v���n�u�����
		GameObject newGameObject = Instantiate(bullet) as GameObject;
		newGameObject.transform.position = newPos;

		Invoke("CreatePrefab2", intervalSec);
	}

	void CreatePrefab2()
	{

		//���̃I�u�W�F�N�g�͈͓̔��Ƀ����_����
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		Vector3 newPos = this.transform.position;
		newPos.x = 7;
		newPos.y = 0;
		newPos.z = 191; //��O�ɕ\��

		//�v���n�u�����
		GameObject newGameObject = Instantiate(bullet) as GameObject;
		newGameObject.transform.position = newPos;

		Invoke("CreatePrefab3", intervalSec);
	}

	void CreatePrefab3()
	{

		//���̃I�u�W�F�N�g�͈͓̔��Ƀ����_����
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		Vector3 newPos = this.transform.position;
		newPos.x = -2;
		newPos.y = 0;
		newPos.z = 191; //��O�ɕ\��

		//�v���n�u�����
		GameObject newGameObject = Instantiate(bullet) as GameObject;
		newGameObject.transform.position = newPos;

		Invoke("CreatePrefab", intervalSec);
	}
}
