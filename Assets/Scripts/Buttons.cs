using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject Panel;

    public void ExitButton()
    {
        Application.Quit();
    }
    public void NextScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        if(index < sceneCount) SceneManager.LoadScene(index + 1);
    }
    public void first() 
    {
        SceneManager.LoadScene(2);
    }
    public void Giris()
    {
        SceneManager.LoadScene(1);
    }
    public void Resume()
    {
        Panel.gameObject.SetActive(true);
    }

}
