using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItem : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 movePos;
    public float MovementSpeed = 0.5f;
    public float BobMagnitude = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movePos = new Vector3(MovementSpeed * Time.time, Mathf.Sin(Time.time * 4.5f) * BobMagnitude, 0.0f);
        transform.position = startPos + movePos;
    }
}
