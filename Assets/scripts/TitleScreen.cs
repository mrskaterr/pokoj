using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    [SerializeField] GameObject Tutorial;
    public void OnPlayButton()
    {
        //PlayerPrefs.SetInt ("Character", Character);
        if(PlayerPrefs.GetInt("Record")!=0)
        {
            Retry();
        }
        else 
        {
            Tutorial.SetActive(true);
        }

        
    }
    public void Retry()
    {
        SceneManager.LoadScene("Game");
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
