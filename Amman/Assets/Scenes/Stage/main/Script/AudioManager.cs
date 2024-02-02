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
            // 関数ToggleAudioが呼ばれたら現在のmuteの値を反転させる
            audioSource.mute = !audioSource.mute;
        }
    }
}