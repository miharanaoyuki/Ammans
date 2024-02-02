using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void ToggleAudio()
    {
        if (audioSource != null)
        {
            // �֐�ToggleAudio���Ă΂ꂽ�猻�݂�mute�̒l�𔽓]������
            audioSource.mute = !audioSource.mute;
        }
    }
}