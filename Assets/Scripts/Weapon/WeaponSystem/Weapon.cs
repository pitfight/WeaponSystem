using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract class Weapon : MonoBehaviour, IWeaponControllable
{
    [SerializeField] protected string weaponName;
    [SerializeField] protected int damage;

    public abstract void Use();

    private void OnEnable()
    {
        transform.DOMoveY(0, 1f).SetEase(Ease.OutElastic);
        transform.DOPunchRotation(Vector3.right, 1f, 25, 2f);
    }
}
