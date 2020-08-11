using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    private Vector2 startPos;
    private Rigidbody2D rigidBody2D;
    private SpriteRenderer sprite;
    public static bool hasBeenDropped = false;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // setup object for pickup
    void OnMouseDown()
    {
        hasBeenDropped = false;
        // store original pos
        startPos = transform.position;
        // freeze item under mouse cursor
        rigidBody2D.freezeRotation = true;
        rigidBody2D.gravityScale = 0.0f;
        gameObject.layer = LayerMask.NameToLayer("HeldItem");
        sprite.sortingOrder = 1;
    }

    // set object to mouse cursor pos
    void OnMouseDrag()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePos.x, mousePos.y);
    }

    // reset object
    void OnMouseUp()
    {
        hasBeenDropped = true;
        if (!DepositScript.isItemCorrect)
        {
            rigidBody2D.freezeRotation = false;
            rigidBody2D.gravityScale = 1.0f;
            gameObject.layer = LayerMask.NameToLayer("RecycleItem");
            sprite.sortingOrder = 0;
            transform.position = startPos;
        }
    }
}
