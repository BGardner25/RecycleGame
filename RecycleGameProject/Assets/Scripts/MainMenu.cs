using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // to load next scene
    // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    // if current scene is main menu, go back to main menu. else go back to pause menu, or just do it in onclick events

    // start game from the beginning i.e. level one
    public void StartGame()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }
}
