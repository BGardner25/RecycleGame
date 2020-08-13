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
    private bool isCompleted = false;

    void Update()
    {
        if(!isCompleted)
            if (FindObjectOfType<ItemManager>().GetLevelObjectCount() == 0)
                LevelComplete();
    }

    // execute on levelcompleted
    public void LevelComplete()
    {
        foreach (AudioSource aS in FindObjectsOfType(typeof(AudioSource)) as AudioSource[])
            aS.Stop();
        FindObjectOfType<AudioManager>().PlaySound("LevelComplete");
        isCompleted = true;
        Time.timeScale = 0;
        MainUI.SetActive(false);
        LevelCompleteUI.SetActive(true);
        levelScoreText.text = "Level Score: " + ScoreDisplay.score;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        ScoreDisplay.score = 0;
        isCompleted = false;
        Time.timeScale = 1;
    }
}
