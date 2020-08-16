using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject GameOverUI;
    public HealthBarScript healthBar;
    public Text scoreText;
    public Text highScoreText;

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
        if (SceneManager.GetActiveScene().name == "InfiniteLevel")
        {
            if (PlayerPrefs.GetFloat("HighScore") < ScoreDisplay.score)
            {
                PlayerPrefs.SetFloat("HighScore", ScoreDisplay.score);
                highScoreText.text = "New High Score!: " + ScoreDisplay.score;
                highScoreText.gameObject.SetActive(true);
            }
            else
            {
                scoreText.text = "Score: " + ScoreDisplay.score;
                scoreText.gameObject.SetActive(true);
            }
        }
    }

    public void ResetLevel()
    {
        ScoreDisplay.score = 0;
        scoreText.gameObject.SetActive(false);
        highScoreText.gameObject.SetActive(false);
        GameOverUI.SetActive(false);
        MainUI.SetActive(true);
        // reset level score
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        FindObjectOfType<PauseScript>().ResumeGame();
    }
}
