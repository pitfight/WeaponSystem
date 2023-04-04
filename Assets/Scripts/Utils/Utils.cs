using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static string WeaponUIHelper<T>(T weapon) where T : Weapon
    {
        return $"Weapon name: {weapon.WeaponName} / Damage: {weapon.Damage}";
    }
}
