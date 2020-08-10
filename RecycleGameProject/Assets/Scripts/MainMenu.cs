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
        ScoreDisplay.score = 0;
        SceneManager.LoadScene("LevelOne");
    }

    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }
}
