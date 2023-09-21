using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import the TMPro namespace

public class ImageOpacityControl : MonoBehaviour
{
    public List<Image> transparentImages = new List<Image>(); // List of Image components you want to make transparent.
    public List<Image> opaqueImages = new List<Image>(); // List of Image components you want to make opaque.
    public List<TextMeshProUGUI> opaqueTexts = new List<TextMeshProUGUI>(); // List of TextMeshPro components you want to make opaque.

    public void MakeImagesTransparent()
    {
        foreach (Image image in transparentImages)
        {
            if (image != null)
            {
                Color imageColor = image.color;
                imageColor.a = 0.0f; // Set alpha channel to 0 (fully transparent)
                image.color = imageColor;
            }
        }
    }

    public void MakeImagesOpaque()
    {
        foreach (Image image in opaqueImages)
        {
            if (image != null)
            {
                Color imageColor = image.color;
                imageColor.a = 1.0f; // Set alpha channel to 1 (fully opaque)
                image.color = imageColor;
            }
        }

        foreach (TextMeshProUGUI text in opaqueTexts)
        {
            if (text != null)
            {
                Color textColor = text.color;
                textColor.a = 1.0f; // Set alpha channel to 1 (fully opaque)
                text.color = textColor;
            }
        }
        
    }
}


