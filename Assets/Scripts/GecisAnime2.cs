using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GecisAnime2 : MonoBehaviour
{
    public Animator anim;


    void Update()
    {
        if (Input.GetMouseButton(0))
        {

        }

    }

    IEnumerator sahne_degistir()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(2);
    }
}

