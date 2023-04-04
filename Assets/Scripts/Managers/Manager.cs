using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private UIManager uiManager;
    [SerializeField] private GameObject[] weapons;

    private IWeaponControllable currentControll;

    private Weapon currentWeapon = null;
    private int indexWeapon = 0;

    private void OnEnable()
    {
        inputManager.OnNextWeapon += SpawnWeapon;
        inputManager.OnUseWeapon += UseWeapon;
    }

    private void Start()
    {
        SpawnWeapon();
    }

    private void OnDisable()
    {
        inputManager.OnNextWeapon -= SpawnWeapon;
        inputManager.OnUseWeapon -= UseWeapon;
    }

    private void UseWeapon()
    {
        currentControll.Use();
    }

    private void SpawnWeapon()
    {
        //currentWeapon =
        currentWeapon = Instantiate(NextWeapon().GetComponent<Weapon>());
        uiManager.SetWeaponInfo(WeaponHelper.WeaponUIHelper(currentWeapon));
        currentControll = currentWeapon;
    }

    private GameObject NextWeapon()
    {
        if (currentWeapon != null)
            Destroy(currentWeapon.gameObject);
        if (indexWeapon == weapons.Length)
            indexWeapon = 0;
        var go = weapons[indexWeapon];
        indexWeapon++;
        return go;
    }
}
