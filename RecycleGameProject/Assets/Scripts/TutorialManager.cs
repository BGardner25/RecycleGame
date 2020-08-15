using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public static bool isTutorialActive = false;
    public MainUI mainUI;
    public GameObject darkScreen;
    public GameObject TutorialPanel;
    public List<GameObject> tutMessages;

    void Start()
    {
        isTutorialActive = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        string tag = "";
        if (other.gameObject.tag == "GeneralWaste")
            tag = other.gameObject.name;
        else
             tag = other.gameObject.tag;
        foreach (GameObject tutObject in tutMessages)
        {
            if (tutObject.tag == tag)
            {
                DisplayTutorial(tutObject);
            }
        }
    }

    public void DisplayTutorial(GameObject tutObject)
    {
        isTutorialActive = true;
        darkScreen.SetActive(true);
        FindObjectOfType<ItemManager>().FreezeAllItems();
        mainUI.SetMainUIVisibility(false);
        TutorialPanel.SetActive(true);
        tutObject.SetActive(true);
    }

    public void RemoveTutorialMessage(GameObject gObject)
    {
        string tag = gObject.tag;
        foreach (GameObject tutObject in tutMessages)
        {
            if (string.Equals("GeneralWaste", tag, System.StringComparison.OrdinalIgnoreCase))
                tag = gObject.transform.name;
            if (string.Equals(tutObject.tag, tag, System.StringComparison.OrdinalIgnoreCase))
            {
                tutObject.SetActive(false);
                TutorialPanel.SetActive(false);
                tutMessages.Remove(tutObject);
                darkScreen.SetActive(false);
                isTutorialActive = false;
                FindObjectOfType<ItemManager>().UnfreezeAllItems();
                mainUI.SetMainUIVisibility(true);
                return;
            }
        }
    }
}
