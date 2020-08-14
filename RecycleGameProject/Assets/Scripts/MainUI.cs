using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(true);
    }

    public void SetMainUIVisibility(bool isHidden)
    {
        gameObject.SetActive(isHidden);
    }
}
