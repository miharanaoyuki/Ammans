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
        {
            fade.FadeIn(0.5f, () => print("フェードイン完了"));
            Invoke("scene", 0.6f);
        }
    }

    void scene()
    {
       
        SceneManager.LoadScene(SceneName);
    }
}