using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleVandalScript : MonoBehaviour
{
    public Vector3 spawnPos;
    public float startTime = 10.0f;
    public float throwTime = 2.5f;
    Animator anim;
    private bool isThrowing;

    void Awake()
    {
        isThrowing = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0;
        InvokeRepeating("ThrowItem", startTime, throwTime);
    }

    void OnMouseDown()
    {
        if (Time.timeScale != 0 && isThrowing)
        {
            isThrowing = false;
            FindObjectOfType<AudioManager>().PlaySound("AngryMan");
            CancelInvoke();
            anim.speed = 0;
            InvokeRepeating("ThrowItem", startTime, throwTime);
        }
    }

    public void ThrowItem()
    {
        isThrowing = true;
        FindObjectOfType<AudioManager>().PlaySound("DropItem");
        anim.speed = 0.2f;
        FindObjectOfType<ItemManager>().SpawnRandomItem(spawnPos);
    }

    public bool GetIsThrowing()
    {
        return isThrowing;
    }

    public void SetStartTime(float startTime)
    {
        this.startTime = startTime;
    }
}
