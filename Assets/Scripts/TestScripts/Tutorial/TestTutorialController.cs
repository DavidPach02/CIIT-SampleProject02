using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTutorialController : MonoBehaviour
{
    public Light lightRef;
    public Rotator rotatorRef;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<TestPlayer>())
        {
            lightRef.enabled = true;
            rotatorRef.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<TestPlayer>())
        {
            lightRef.enabled = false;
            rotatorRef.enabled = false;
            rotatorRef.gameObject.transform.rotation = Quaternion.Euler(15f, 0f, 0f);
        }
    }
}
