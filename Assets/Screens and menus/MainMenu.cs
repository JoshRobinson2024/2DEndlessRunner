using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public void PlayGame() 
    {
        SceneManager.LoadSceneAsync(1);
        
        Time.timeScale = 1.0f;
    }

    public void Credits()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Return()
    { 
        SceneManager.LoadSceneAsync(0);
    
    }

    public void QuitGame()
    {
        Application.Quit();

    }
}
