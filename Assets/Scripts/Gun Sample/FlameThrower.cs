using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : Gun
{
    public override void Use()
    {
        base.Use();
        Debug.Log(name + " fired!");
        ApplyFireDamage();
    }

    private void ApplyFireDamage()
    {
        Debug.Log(name + " set target on fire!");
    }
}
