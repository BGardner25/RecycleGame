using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteItems : MonoBehaviour
{
    public int minNumItems = 4;
    public int maxNumItems = 8;
    public float flowMagnitude = 1.0f;
    public Vector3 spawnPos = new Vector3(-9.0f, -0.5f, -9.0f);
    public MaleVandalScript nearVandal;
    public MaleVandalScript farVandal;
    ItemManager itemManager;
    private float maxFlowMagnitude = 5.0f;
    private int spawnCount = 1;

    void Awake()
    {
        minNumItems = 4;
        flowMagnitude = 1.0f;
        spawnCount = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        itemManager = FindObjectOfType<ItemManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCount % 6 == 0)
        {
            spawnCount = 1;
            IncreaseDifficulty();
        }
        if (itemManager.GetLevelObjectCount() < minNumItems)
        {
            itemManager.SpawnRandomItem(spawnPos);
            spawnCount++;
        }
    }

    void IncreaseDifficulty()
    {
        if (minNumItems <= maxNumItems)
        {
            nearVandal.SetStartTime(nearVandal.startTime - 2);
            farVandal.SetStartTime(farVandal.startTime - 2);
            minNumItems++;
        }
        if (flowMagnitude <= maxFlowMagnitude)
        {
            flowMagnitude += 0.2f;
            FindObjectOfType<BuoyancyScript>().SetFlowMagnitude(flowMagnitude);
        }
    }
}
