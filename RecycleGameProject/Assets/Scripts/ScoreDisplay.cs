using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // set score to 0?   
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

        // on correct collision, increase score

        if(Input.GetKeyDown(KeyCode.Space))
        {
            score+=100;
        }
    }
}
