using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValuePercentage : MonoBehaviour
{
    public Slider slider;
    public TMP_Text percentageText;

    void Update()
    {
        int volume = Mathf.RoundToInt(GetSliderValuePercentage()); // Deðeri tam sayýya yuvarla
        percentageText.text = volume.ToString() + "%";
    }

    public float GetSliderValuePercentage()
    {
        float normalizedValue = slider.normalizedValue;
        float percentage = normalizedValue * 100f;
        return percentage;
    }
}



