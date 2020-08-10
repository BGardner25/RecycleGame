using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCompleteScript : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject LevelCompleteUI;
    public Text levelScoreText;

    // execute on levelcompleted
    public void LevelComplete()
    {
        Time.timeScale = 0;
        MainUI.SetActive(false);
        LevelCompleteUI.SetActive(true);
        levelScoreText.text = "Level Score: " + ScoreDisplay.score;
    }

    public void NextLevel()
    {
        ScoreDisplay.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }
}
