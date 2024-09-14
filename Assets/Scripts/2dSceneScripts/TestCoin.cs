using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCoin : MonoBehaviour
{
    public int CoinValue;
    void OnTriggerEnter2D (Collider2D objectCollidedWith) 
    {
        if (objectCollidedWith.gameObject.tag == "Player")
        {
            Debug.Log("You got a coin!");
        }
        Destroy(gameObject);
    }

    void OnDestroy ()
    {
        TestGameManager.instance.AddScore(CoinValue);
        Debug.Log("Coin Destroyed!");
    }
}
