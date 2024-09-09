using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    public string name;

    public virtual void Use()
    {
        Debug.Log("Used " + this.name);
    }
}

