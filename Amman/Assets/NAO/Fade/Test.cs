using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Test : MonoBehaviour
{
    public string SceneName;
    public Fade fade;
	public void OnClickStartButton()
	{
		if (Input.GetKeyDown(KeyCode.Return));
　　　　　　{
                     Invoke("scene", 0.6f);
            }
	}

  void Scene()
  {
          fade.FadeIn(0.5f,() =>print("フェードイン完了"));
           SceneManager.LoadScene(SceneName);
  }
}