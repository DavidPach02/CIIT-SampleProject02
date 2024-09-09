using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Gun : Weapon
{
    protected int maxBullets = 20;

    public override void Use()
    {
        Debug.Log("Ammo is at " + maxBullets);
        Debug.Log(this.name + " shot a bullet!");
        maxBullets -= 1;
        Debug.Log("Ammo is at " + maxBullets);
    }
}
