using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCollider : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D objectCollidedWith)
    {
        if (objectCollidedWith.gameObject.tag == "Player")
        {
            Debug.Log("Destroying Player!");
            Destroy(objectCollidedWith.gameObject);

            TestGameManager.Instance.ModifyLives(1);
        }
    }
}
