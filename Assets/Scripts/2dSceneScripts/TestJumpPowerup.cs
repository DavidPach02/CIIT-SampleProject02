using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJumpPowerup : MonoBehaviour
{
    public float IncreasedJumpValue;
    public float targetFieldOfView = 90;

    public GameObject sfxPlayer;

    void OnTriggerEnter2D (Collider2D objectCollidedWith) 
    {
        if (objectCollidedWith.gameObject.tag == "Player")
        {
            //Debug.Log("You got a jump powerup");
            TestGameManager.Instance.ModifyJump(IncreasedJumpValue);
            objectCollidedWith.gameObject.GetComponent<TestPlayer>().JumpPower = TestGameManager.Instance.SetJumpValue();

            GameObject sfxPlayerRef = Instantiate(sfxPlayer, null, true);
            sfxPlayer.transform.position = this.transform.position;

            TestGameManager.Instance._camera.fieldOfView = targetFieldOfView;
        }
        Destroy(gameObject);
    }

    void OnDestroy ()
    {
        //Debug.Log("Powerup Destroyed!");
    }


}
