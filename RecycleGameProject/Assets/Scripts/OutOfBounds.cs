using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public HealthBarScript healthBar;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.parent.tag == "RecycleItem")
        {
            Destroy(other.gameObject);
            healthBar.RemoveHealth();
        }

    }
            

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
