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
        volumeSlider.value = audioSource.volume;

        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    private void ChangeVolume(int newVolume)
    {
        audioSource.volume = newVolume;
    }
}
