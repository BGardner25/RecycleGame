﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class HealthBarScript : MonoBehaviour
{

    public List<GameObject> healthBar;
    public Sprite greyHeart;
    public Sprite redHeart;
    public ScreenShakeScript screenShake;
    private int count = 5;
    private List<GameObject> fallingHearts;
    private bool[] isHeartsFalling;
    private GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = new List<GameObject>();
        fallingHearts = new List<GameObject>();
        foreach (Transform child in transform)
        {
            clone = Instantiate(child.gameObject);
            clone.GetComponent<Image>().sprite = redHeart;
            GameObjectUtility.SetParentAndAlign(clone, child.gameObject);
            fallingHearts.Add(clone);
            healthBar.Add(child.gameObject);
        }
        healthBar.Reverse();
        fallingHearts.Reverse();
        count = healthBar.Count;
        isHeartsFalling = new bool[count];
    }

    void Update()
    {
        for(int i = isHeartsFalling.Length - 1; i > 0; i--)
            if (isHeartsFalling[i])
                if (fallingHearts[i].transform.position.y >= -40.0f)
                    fallingHearts[i].transform.Translate(0.0f, -1.0f, 0.0f);
    }

    public int GetHealthCount()
    {
        return count;
    }

    public void ResetHealthCount()
    {
        count = 5;
    }

    public void RemoveHealth()
    {
        screenShake.ScreenShake();
        //Instantiate(fallingHeart, healthBar[count - 1].transform.position, Quaternion.identity);
        isHeartsFalling[count - 1] = true;
        healthBar[count - 1].GetComponent<Image>().sprite = greyHeart;
        count--;
    }
}
