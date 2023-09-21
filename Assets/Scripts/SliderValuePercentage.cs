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
        float percentage = GetSliderValuePercentage();
        percentageText.text = percentage.ToString("F1") + "%";

        // Debug.LogError kullan�m� �rne�i:
        Debug.LogError("Hata mesaj� burada!");
    }

    public float GetSliderValuePercentage()
    {
        float normalizedValue = slider.normalizedValue;
        float percentage = normalizedValue * 100f;
        return percentage;
    }
}









