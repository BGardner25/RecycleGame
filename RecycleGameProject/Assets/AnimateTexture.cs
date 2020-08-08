using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateTexture : MonoBehaviour {

    public float moveX = 0.5f;
    public float moveY = 0.5f;

    // Update is called once per frame
    void Update() {
        float offsetX = Time.time * moveX;
        float offsetY = Time.time * moveY;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
