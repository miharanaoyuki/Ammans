using UnityEngine;

public class PlayerMoveSound_stage : MonoBehaviour
{
    bool check;
    int Go = 0;

    // Start is called before the first frame update
    void Start()
    {
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Go += 1;
            check = true;
            //// AudioClipÇ…ê›íËÇµÇΩâπåπÇçƒê∂Ç∑ÇÈ
            //GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Go += 1;
            check = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Go += 1;
            check = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Go += 1;
            check = true;
        }


        if (Input.GetKeyUp(KeyCode.W))
        {
            Go -= 1;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Go -= 1;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Go -= 1;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Go -= 1;
        }

        if (Go == 1 && check == true)
        {
            GetComponent<AudioSource>().Play();
            check = false;
        }

        if (Go == 0 || Build.the_world == true)
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
