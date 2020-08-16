using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuoyancyScript : MonoBehaviour
{
    public BuoyancyEffector2D buoyancy;

    public void SetFlowMagnitude(float flowMagnitude)
    {
        buoyancy.flowMagnitude = flowMagnitude;
    }
}
