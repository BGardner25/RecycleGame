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

    void Update()
    {
        if (ItemManager.levelObjects.Count == 0)
            LevelComplete();
    }

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        ScoreDisplay.score = 0;
        Time.timeScale = 1;
    }
}
