using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Weapon weapon = new Weapon();
        weapon.name = "Generic weapon";
        weapon.Use();

        Weapon gun = new Gun();
        gun.name = "AK47";
        gun.Use();

        FlameThrower flamethrower = new FlameThrower();
        flamethrower.name = "Arachnid Disintegrator";
        flamethrower.Use();

        Weapon knife = new Knife();
        knife.name = "Knife";
        knife.Use();
    }
}
