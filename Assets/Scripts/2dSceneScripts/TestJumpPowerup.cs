using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJumpPowerup : MonoBehaviour
{
    public float IncreasedJumpValue;

    void OnTriggerEnter2D (Collider2D objectCollidedWith) 
    {
        if (objectCollidedWith.gameObject.tag == "Player")
        {
            Debug.Log("You got a jump powerup");
            TestGameManager.instance.ModifyJump(IncreasedJumpValue);
            objectCollidedWith.gameObject.GetComponent<TestPlayer>().JumpPower = TestGameManager.instance.SetJumpValue();
        }
        Destroy(gameObject);
    }

    void OnDestroy ()
    {
        Debug.Log("Powerup Destroyed!");
    }


}
