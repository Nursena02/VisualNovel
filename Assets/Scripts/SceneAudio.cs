using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAudio : MonoBehaviour
{
    public AudioSource sceneAudioSource;

    private void Start()
    {
        AudioManager audioManager = AudioManager.GetInstance();

        if (audioManager != null)
        {
            sceneAudioSource.volume = audioManager.globalVolume;
        }
        else
        {
            Debug.LogError("AudioManager not found in the scene.");
        }
    }
}

