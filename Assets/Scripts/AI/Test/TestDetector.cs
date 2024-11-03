using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDetector : MonoBehaviour
{
    public TestEnemy testEnemyRef;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            testEnemyRef.playerRef = collision.GetComponent<TestPlayer>();
            testEnemyRef.GetComponent<Animator>().SetBool("PlayerIsDetected", true);
            //testEnemyRef.GetComponent<Animator>().SetBool("PlayerDetected", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            testEnemyRef.playerRef = null;
            testEnemyRef.GetComponent<Animator>().SetBool("PlayerIsDetected", false);
            //testEnemyRef.GetComponent<Animator>().SetBool("PlayerDetected", false);
        }
    }
}
