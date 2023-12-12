using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_create : MonoBehaviour
{
	public GameObject bullet; //作るプレハブ：Inspectorで指定
	public float intervalSec = 2; //作成間隔（秒）：Inspectorで指定する
								  //public AudioClip bossbulletsou;

	Transform tf; //敵のTransform

	void Start()
	{
		//Debug.Log(attack_flag);

		//指定秒後に
		Invoke("CreatePrefab2", intervalSec);
	}

	void Update()
	{

	}

	void CreatePrefab()
	{

		//このオブジェクトの範囲内にランダムに
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		Vector3 newPos = this.transform.position;
		newPos.x = 2.5f;
		newPos.y = 0;
		newPos.z = 191; //手前に表示

		//プレハブを作る
		GameObject newGameObject = Instantiate(bullet) as GameObject;
		newGameObject.transform.position = newPos;

		Invoke("CreatePrefab2", intervalSec);
	}

	void CreatePrefab2()
	{

		//このオブジェクトの範囲内にランダムに
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		Vector3 newPos = this.transform.position;
		newPos.x = 7;
		newPos.y = 0;
		newPos.z = 191; //手前に表示

		//プレハブを作る
		GameObject newGameObject = Instantiate(bullet) as GameObject;
		newGameObject.transform.position = newPos;

		Invoke("CreatePrefab3", intervalSec);
	}

	void CreatePrefab3()
	{

		//このオブジェクトの範囲内にランダムに
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		Vector3 newPos = this.transform.position;
		newPos.x = -2;
		newPos.y = 0;
		newPos.z = 191; //手前に表示

		//プレハブを作る
		GameObject newGameObject = Instantiate(bullet) as GameObject;
		newGameObject.transform.position = newPos;

		Invoke("CreatePrefab", intervalSec);
	}
}
