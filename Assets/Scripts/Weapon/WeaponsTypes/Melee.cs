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
        Debug.Log($"Hit: {WeaponName}");
    }

    private void WeaponIsBroke()
    {
        Debug.Log($"Weapon is Broke: {WeaponName}");
    }
}
