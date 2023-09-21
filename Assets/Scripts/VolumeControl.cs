using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    private void Start()
    {
        volumeSlider.value = Mathf.RoundToInt(audioSource.volume); // Ses düzeyini tam sayýya yuvarla

        // onValueChanged dinleyicisini UpdateVolume metoduna baðla
        volumeSlider.onValueChanged.AddListener(UpdateVolume);
    }

    private void UpdateVolume(float newVolume)
    {
        audioSource.volume = Mathf.RoundToInt(newVolume); // Yeni ses düzeyini tam sayýya yuvarla
    }
}
