using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI weaponInfo;

    public void SetWeaponInfo(string info)
    {
        weaponInfo.text = info;
    }
}
