using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotator : MonoBehaviour
{
    public Vector3 speed = new Vector3(5f, 0f, 0f);

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(speed.x * Time.deltaTime, speed.y * Time.deltaTime, speed.z * Time.deltaTime);
    }
}
