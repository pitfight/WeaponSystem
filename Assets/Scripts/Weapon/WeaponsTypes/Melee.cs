using UnityEngine;

public class Melee : Weapon
{
    [SerializeField] private int durability;
    private int currentDurability;

    private void Start()
    {
        currentDurability = durability;
    }

    public override void Use()
    {
        if (!IsBroken())
        {
            Hit();
        }
        else
        {
            WeaponBroke();
        }
    }

    private void Hit()
    {
        currentDurability--;
        Debug.Log($"Hit: {WeaponName}");
    }

    private void WeaponBroke()
    {
        Debug.Log($"Weapon is Broke: {WeaponName}");
    }

    private bool IsBroken()
    {
        if (currentDurability == 0) return true;
        else return false;
    }

    private void Repair()
    {
        currentDurability = durability;
    }
}
