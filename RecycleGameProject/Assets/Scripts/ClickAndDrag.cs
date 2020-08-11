using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    private Vector2 startPos;

    void OnMouseDown()
    {
        startPos = transform.position;
        //this.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
        // store original pos
    }

    void OnMouseDrag()
    {
        Debug.Log("dragging");
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.Translate(mousePos);
    }

    void OnMouseUp()
    {
        transform.position = startPos;
    }
}
