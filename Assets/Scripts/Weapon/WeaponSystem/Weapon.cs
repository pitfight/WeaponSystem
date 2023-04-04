using UnityEngine;
using DG.Tweening;

public abstract class Weapon : MonoBehaviour, IWeaponControllable
{
    [field: SerializeField] public string WeaponName { get; private set; }
    [field: SerializeField] public int Damage { get; private set; }

    private float timeDoMoveY = 0.5f;
    private float timeDOLocalRotate = 5f;

    public abstract void Use();

    private void OnEnable()
    {
        transform.DOMoveY(0, timeDoMoveY).SetEase(Ease.OutBack);
        transform.DOLocalRotate(new Vector3(0f, 360f, 0), timeDOLocalRotate, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
    }

    private void OnDestroy()
    {
        transform.DOKill(false);
    }
}
