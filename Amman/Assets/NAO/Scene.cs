using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public string SceneName;
    public Fade fade;
 
	public void OnClickStartButton()
	{
	    if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene(SceneName);
        }
}