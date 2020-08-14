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
        if (Time.timeScale != 0)
        {
            hasBeenDropped = false;
            // store original pos
            startPos = transform.position;
            FindObjectOfType<AudioManager>().PlaySound("PickUpItem");
            // freeze item under mouse cursor
            rigidBody2D.freezeRotation = true;
            rigidBody2D.gravityScale = 0.0f;
            gameObject.layer = LayerMask.NameToLayer("HeldItem");
            sprite.sortingOrder = 3;
        }
    }

    // set object to mouse cursor pos
    void OnMouseDrag()
    {
        if (Time.timeScale != 0)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePos.x, mousePos.y);
        }
    }

    // reset object
    void OnMouseUp()
    {
        if (Time.timeScale != 0)
        {
            hasBeenDropped = true;
            if (!DepositScript.isItemCorrect)
            {
                rigidBody2D.freezeRotation = false;
                rigidBody2D.gravityScale = 1.0f;
                gameObject.layer = LayerMask.NameToLayer("RecycleItem");
                sprite.sortingOrder = 2;
                transform.position = startPos;
                FindObjectOfType<AudioManager>().PlaySound("DropItem");
            }
        }
    }
}
