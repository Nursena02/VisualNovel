using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GecisAnime1 : MonoBehaviour
{
    public Animator anim;
    private bool buttonClicked = false;

    public void OnButtonClick()
    {
        buttonClicked = true;
    }

    void Update()
    {
        if (buttonClicked)
        {
            StartCoroutine(sahne_degistir());
        }
    }

    IEnumerator sahne_degistir()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(2);
        
    }
}
