using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasPlayed : MonoBehaviour
{
    public GameObject AngryManTutorial;
    public MaleVandalScript maleVandal;
    private bool hasThrown;

    // Update is called once per frame
    void Update()
    {
        if (hasThrown)
        {
            Time.timeScale = 0;
            AngryManTutorial.SetActive(true);
            hasThrown = false;
        }
        if (maleVandal.GetIsThrowing())
            hasThrown = true;
    }

    public void DisableTutorial()
    {
        AngryManTutorial.SetActive(false);
        Time.timeScale = 1;
        enabled = false;
    }
}
