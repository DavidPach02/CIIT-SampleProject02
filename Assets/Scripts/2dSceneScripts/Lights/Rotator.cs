using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 speed = new Vector3(5f, 0f, 0f);

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(speed * Time.deltaTime);
    }
}
