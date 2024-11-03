using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinker : MonoBehaviour
{
    public Light lightRef;

    public float blinkTime = 1f;
    public float curTime = 0f;

    private void Update()
    {
        if (blinkTime < curTime)
        {
            curTime += 1f;
        }
        else
        {
            curTime = 0f;
            if (lightRef.enabled)
            {
                lightRef.enabled = false;
            }
            else
            {
                lightRef.enabled = true;
            }
        }
    }
}
