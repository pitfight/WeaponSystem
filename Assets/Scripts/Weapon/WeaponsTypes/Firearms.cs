using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firearms : Weapon
{
    [SerializeField] private int bullets;

    public override void Use()
    {
        if (bullets > 0)
        {
            Fire();
        }
        else
        {
            ClipIsEmpty();
        }
    }

    private void Fire()
    {
        bullets--;
        Debug.Log($"Pew Pew: {WeaponName}");
    }

    private void ClipIsEmpty()
    {
        Debug.Log($"Clip is Empty: {WeaponName}");
    }
}
