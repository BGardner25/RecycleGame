using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    public static bool isPaused = false;
    public GameObject UIPauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = System.Convert.ToBoolean(Time.timeScale);
    }

    public void PauseGame(bool enablePauseMenu = true)
    {
        UIPauseMenu.SetActive(enablePauseMenu);
        FindObjectOfType<AudioManager>().Pause();
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        UIPauseMenu.SetActive(false);
        FindObjectOfType<AudioManager>().Resume();
        Time.timeScale = 1;
    }

    // toggle between pause and resume
    public void TogglePause()
    {
        isPaused = !isPaused;
        if (isPaused)
            ResumeGame();
        else
            PauseGame();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
