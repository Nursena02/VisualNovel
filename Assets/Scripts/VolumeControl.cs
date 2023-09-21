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
        volumeSlider.value = Mathf.RoundToInt(audioSource.volume); // Ses d�zeyini tam say�ya yuvarla

        // onValueChanged dinleyicisini UpdateVolume metoduna ba�la
        volumeSlider.onValueChanged.AddListener(UpdateVolume);
    }

    private void UpdateVolume(float newVolume)
    {
        audioSource.volume = Mathf.RoundToInt(newVolume); // Yeni ses d�zeyini tam say�ya yuvarla
    }
}
