using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCoin : MonoBehaviour
{
    public string id;
    public int CoinValue;

    public TestSFXPlayer sfxPlayer;

    void OnTriggerEnter2D (Collider2D objectCollidedWith) 
    {
        if (objectCollidedWith.gameObject.tag == "Player")
        {
            //Debug.Log("You got a coin!");
            // Play SFX
            if (sfxPlayer != null)
            {
                Instantiate(sfxPlayer.gameObject, null, true);
                sfxPlayer.transform.position = this.transform.position;
            }

            // Destroy coin
            Destroy(gameObject);
        }
    }

    void OnDestroy ()
    {
        TestGameManager.Instance.AddScore(CoinValue);
        //Debug.Log("Coin Destroyed!");
    }
}
