using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public HealthBarScript healthBar;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "NoRecycle")
        {
            FindObjectOfType<ItemManager>().DestroyItem(other.gameObject);
            return;
        }
        if(other.transform.parent.tag == "RecycleItem")
        {
            FindObjectOfType<AudioManager>().PlaySound("EndOfRiver");
            FindObjectOfType<ItemManager>().DestroyItem(other.gameObject);
            healthBar.RemoveHealth();
        }

    }
}
