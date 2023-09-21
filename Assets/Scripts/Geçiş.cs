using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Geçiş : MonoBehaviour
{
    Color color;
    private bool karartma;
    [SerializeField] private Image img;
    // Start is called before the first frame update
    public void playButton(float alpha)
    {
        /*Color color = img.color;
       color.a = alpha;
       img.color = color;
       karartma = true;
        */
        Animator anim = GetComponent<Animator>();
        SceneManager.LoadScene(0);


    }
    // Update is called once per frame
    void Update()
    {
        if (karartma)
        {
            if (color.a != 255)
            {
                color.a += 0.5f;
            }
            else
            {
                karartma = false;
                img.color = color;
            }
        }
    }
}
