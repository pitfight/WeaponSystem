using UnityEngine;

public class Firearms : Weapon
{
    [SerializeField] private int bullets;
    private int currentBullets;

    private void Start()
    {
        currentBullets = bullets;
    }

    public override void Use()
    {
        if (!IsEmpty())
        {
            Fire();
        }
        else
        {
            ClipEmpty();
        }
    }

    private void Fire()
    {
        currentBullets--;
        Debug.Log($"Pew Pew: {WeaponName}");
    }

    private void ClipEmpty()
    {
        Debug.Log($"Clip is Empty: {WeaponName}");
    }

    private bool IsEmpty()
    {
        if (currentBullets == 0) return true;
        else return false;
    }

    private void Reload()
    {
        currentBullets = bullets;
    }
}
