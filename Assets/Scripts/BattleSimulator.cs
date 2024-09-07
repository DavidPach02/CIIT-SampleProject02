using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSimulator : MonoBehaviour
{
    public string playerName;
    public int playerMaxHP = 30;
    public int playerCurHP = 30;

    public int minDamage = 5;
    public int maxDamage = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(playerName + " HP: " + playerCurHP + "/" + playerMaxHP);

        while (playerCurHP > 0)
        {
            int targetDamage = Random.Range(minDamage, maxDamage + 1);
            playerCurHP -= targetDamage;
            Debug.Log(playerName + " took " + targetDamage + " damage ");
            Debug.Log(playerName + " HP: " + playerCurHP + "/" + playerMaxHP);

            if (playerCurHP <= 0)
            {
                Debug.Log(playerName + " is dead");
            }
        }
    }
}