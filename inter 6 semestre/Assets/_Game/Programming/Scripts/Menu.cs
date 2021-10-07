using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenu, UIElements;

    bool paused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    public void Pause()
    {
        paused = true;
        pauseMenu.SetActive(true);
        UIElements.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        paused = false;
        pauseMenu.SetActive(false);
        UIElements.SetActive(true);
        Time.timeScale = 1;
    }

    //

    public void GoToScene(string sceneName)
    {
        if (paused)
        {
            Resume();
        }

        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
