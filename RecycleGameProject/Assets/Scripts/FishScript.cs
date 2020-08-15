using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * 0.08f);
    }
}
