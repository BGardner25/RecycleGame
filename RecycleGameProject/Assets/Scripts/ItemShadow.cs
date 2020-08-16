using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ItemShadow : MonoBehaviour
{
    public Material mat;
    public Vector2 offset;

    SpriteRenderer spriteRenderer;
    GameObject shadowObject;

    // Start is called before the first frame update
    void Start()
    {
        shadowObject = new GameObject("ItemShadow");
        shadowObject.transform.parent = transform;
        shadowObject.transform.localPosition = (Vector3)offset;
        shadowObject.transform.localRotation = Quaternion.identity;

        spriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer shadowRenderer = shadowObject.AddComponent<SpriteRenderer>();
        shadowRenderer.sprite = spriteRenderer.sprite;
        shadowRenderer.material = mat;
        shadowObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        

        shadowRenderer.sortingLayerName = spriteRenderer.sortingLayerName;
        shadowRenderer.sortingOrder = spriteRenderer.sortingOrder - 1;
    }

    // Update is called once per frame after all other Update functions
    void LateUpdate()
    {
        shadowObject.transform.position = transform.position + (Vector3)offset;
        shadowObject.transform.rotation = transform.rotation;
    }
}
