using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    [SerializeField] GameObject Tutorial;
    public void OnPlayButton()
    {
            Retry();
    }
    public void Retry()
    {
        SceneManager.LoadScene(1);
    }

    public void Pasue()
    {
        Time.timeScale=0f;
    }
    public void Resume()
    {
        Time.timeScale=1f;
    }
    public void Menu()
    {
        Resume();
        SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
