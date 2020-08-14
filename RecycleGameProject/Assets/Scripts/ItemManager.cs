﻿using System.Collections;
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

    public void FreezeAllItems()
    {
        foreach(GameObject gObject in levelObjects)
            gObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
    }

    public void UnfreezeAllItems()
    {
        foreach (GameObject gObject in levelObjects)
            gObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }
}
