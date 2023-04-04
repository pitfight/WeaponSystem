using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Action OnNextWeapon;
    public Action OnUseWeapon;

    [SerializeField] private KeyCode nextWeapon = KeyCode.Mouse1;
    [SerializeField] private KeyCode useWeapon = KeyCode.Mouse0;

    void Update()
    {
        if (Input.GetKeyDown(nextWeapon))
        {
            OnNextWeapon?.Invoke();
        }
        else if (Input.GetKeyDown(useWeapon))
        {
            OnUseWeapon?.Invoke();
        }
    }
}
