using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            clone.transform.SetParent(child.gameObject.transform);
            clone.transform.localPosition = gameObject.transform.localPosition + new Vector3(-58, -54, 0);
            clone.transform.localScale = gameObject.transform.localScale;
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
                    fallingHearts[i].transform.Translate(0.0f, -3.0f, 0.0f);
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
        if(count > 1)
            screenShake.ScreenShake();
        if (TutorialManager.isTutorialActive)
            return;
        isHeartsFalling[count - 1] = true;
        healthBar[count - 1].GetComponent<Image>().sprite = greyHeart;
        count--;
    }
}
