using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapon
{
    public int damage = 30;

    public override void Use()
    {
        //base.Use();
        Debug.Log(this.name + " slashed for " + this.damage + " damage!");
    }
}
