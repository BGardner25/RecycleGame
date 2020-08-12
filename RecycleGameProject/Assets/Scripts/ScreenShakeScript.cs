using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Original implementation by Matt Buckley
* https://medium.com/@mattThousand/basic-2d-screen-shake-in-unity-9c27b56b516
*/

public class ScreenShakeScript : MonoBehaviour
{
    Vector3 startPos;
    private Transform tF;
    private float shakeTime = 0.0f;
    private float magnitude = 0.015f;
    private float damping = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if(shakeTime > 0)
        {
            transform.localPosition = startPos + Random.insideUnitSphere * magnitude;
            shakeTime -= Time.deltaTime * damping;
        }
        else
        {
            shakeTime = 0.0f;
            transform.localPosition = startPos;
        }
    }

    public void ScreenShake()
    {
        shakeTime = 1.0f;
    }

    void Awake()
    {
        if (!transform)
            tF = GetComponent(typeof(Transform)) as Transform;
    }

    void OnEnable()
    {
        startPos = transform.localPosition;
    }
}
