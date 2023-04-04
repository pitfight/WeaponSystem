using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : Weapon
{
    [SerializeField] private int durability;

    public override void Use()
    {
        if (durability > 0)
        {
            Hit();
        }
        else
        {
            WeaponIsBroke();
        }
    }

    private void Hit()
    {
        durability--;
        Debug.Log($"Bam Bam: {weaponName}");
    }

    private void WeaponIsBroke()
    {
        Debug.Log($"Weapon is Broke: {weaponName}");
    }
}
