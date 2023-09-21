using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackgroundChanger : MonoBehaviour
{
    public List<Sprite> backgrounds;
    private Image backgroundImage;
    private int currentLine;
    void Start()
    {
        backgroundImage = GetComponent<Image>();
        currentLine = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentLine++;
            if (currentLine >= backgrounds.Count)
            {
                currentLine = 0;
            }
            backgroundImage.sprite = backgrounds[currentLine];
        }
    }
}


