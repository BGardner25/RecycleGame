using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public List<GameObject> levelObjects;

    // Start is called before the first frame update
    void Start()
    {
        levelObjects = new List<GameObject>();
        foreach (Transform child in transform)
            levelObjects.Add(child.gameObject);
    }

    public void DestroyItem(GameObject gObject)
    {
        Destroy(gObject);
        levelObjects.Remove(gObject);
    }

    public int GetLevelObjectCount()
    {
        return levelObjects.Count;
    }
}
