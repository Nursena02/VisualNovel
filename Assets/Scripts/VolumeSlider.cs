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
            volumeSlider.value = Mathf.RoundToInt(audioManager.globalVolume); // Global ses d�zeyini tam say�ya yuvarla
            // onValueChanged dinleyicisini UpdateGlobalVolume metoduna ba�la
            volumeSlider.onValueChanged.AddListener(UpdateGlobalVolume);
        }
        else
        {
            Debug.LogError("AudioManager not found in the scene.");
        }
    }

    private void UpdateGlobalVolume(float newVolume)
    {
        AudioManager audioManager = AudioManager.GetInstance();

        if (audioManager != null)
        {
            audioManager.globalVolume = Mathf.RoundToInt(newVolume); // Yeni global ses d�zeyini tam say�ya yuvarla
        }
    }
}









