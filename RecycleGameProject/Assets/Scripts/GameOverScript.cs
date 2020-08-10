using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject GameOverUI;

    public void GameOver()
    {
        Time.timeScale = 0;
        MainUI.SetActive(false);
        GameOverUI.SetActive(true);
    }

    public void ResetLevel()
    {
        ScoreDisplay.score = 0;
        GameOverUI.SetActive(false);
        MainUI.SetActive(true);
        // reset level score
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
