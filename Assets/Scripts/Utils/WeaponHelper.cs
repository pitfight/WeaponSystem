public static class WeaponHelper
{
    public static string WeaponUIHelper<T>(T weapon) where T : Weapon
    {
        return $"Weapon name: {weapon.WeaponName} / Damage: {weapon.Damage}";
    }
}
