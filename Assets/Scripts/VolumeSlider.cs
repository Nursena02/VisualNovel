using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {
        AudioManager audioManager = AudioManager.GetInstance();

        if (audioManager != null)
        {
            volumeSlider.value = audioManager.globalVolume;
            volumeSlider.onValueChanged.AddListener(ChangeGlobalVolume);
        }
        else
        {
            Debug.LogError("AudioManager not found in the scene.");
        }
    }

    private void ChangeGlobalVolume(float newVolume)
    {
        AudioManager audioManager = AudioManager.GetInstance();

        if (audioManager != null)
        {
            audioManager.globalVolume = newVolume;
        }
    }
}


