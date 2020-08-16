using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    Vector2 moveDir;

    void Start()
    {
        moveDir = transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveDir != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveDir.y, moveDir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        GetComponent<Rigidbody2D>().AddForce(transform.right * 0.08f);
    }
}
