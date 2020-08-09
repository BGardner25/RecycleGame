using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    // toggle between pause and resume
    public void TogglePause()
    {
        bool isPaused = System.Convert.ToBoolean(Time.timeScale);
        isPaused = !isPaused;
        Time.timeScale = System.Convert.ToInt32(isPaused);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
