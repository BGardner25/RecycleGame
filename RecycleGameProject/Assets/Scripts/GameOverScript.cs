using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject GameOverUI;
    public HealthBarScript healthBar;

    void Update()
    {
        if (healthBar.GetHealthCount() == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        FindObjectOfType<PauseScript>().PauseGame(false);
        healthBar.ResetHealthCount();
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
        FindObjectOfType<PauseScript>().ResumeGame();
    }
}
