using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D objectCollidedWith)
    {
        if (objectCollidedWith.gameObject.tag == "Player")
        {
            Debug.Log("Destroying Player and Enemy!");
            Destroy(objectCollidedWith.gameObject);
            Destroy(gameObject);
        }
    }
}
