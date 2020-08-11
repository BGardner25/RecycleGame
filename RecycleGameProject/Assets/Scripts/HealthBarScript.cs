using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    public List<GameObject> healthBar;
    private int count = 5;
    public Sprite greyHeart;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = new List<GameObject>();
        foreach (Transform child in transform)
            healthBar.Add(child.gameObject);
        healthBar.Reverse();
        count = healthBar.Count;
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
        healthBar[count - 1].GetComponent<Image>().sprite = greyHeart;
        count--;
    }
}
