using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // to load next scene
    // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    // start game from the beginning i.e. level one
    public void StartGame()
    {
        Time.timeScale = 1;
        ScoreDisplay.score = 0;
        SceneManager.LoadScene("Level01");
    }

    public void StartInfinite()
    {
        Time.timeScale = 1;
        ScoreDisplay.score = 0;
        SceneManager.LoadScene("InfiniteLevel");
    }

    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }
}
