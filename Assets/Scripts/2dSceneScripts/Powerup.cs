using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    // For 3D
    //private void OnTriggerEnter(Collider other)
    //{

    //}

    public float IncreaseJumpValue = 50f;

    // For 2D
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name + " hit the powerup!");
        // Apply the powerup
        if (collision.gameObject.tag == "Player")
        {
            TestGameManager.Instance.ModifyJump(IncreaseJumpValue);
            collision.gameObject.GetComponent<TestPlayer>().JumpPower = TestGameManager.Instance.SetJumpValue();
            Destroy(this.gameObject);
        }
    }
}
