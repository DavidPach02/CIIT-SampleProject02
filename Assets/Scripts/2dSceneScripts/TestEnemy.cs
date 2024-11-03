using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    public List<Transform> positions;
    public TestPlayer playerRef;

    void OnCollisionEnter2D (Collision2D objectCollidedWith)
    {
        if (objectCollidedWith.gameObject.tag == "Player")
        {
            Debug.Log("Destroying Player and Enemy!");
            Destroy(objectCollidedWith.gameObject);

            TestGameManager.Instance.ModifyLives(1);
            //Destroy(gameObject);
        }
    }
}
