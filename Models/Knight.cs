using realmCommander.Interfaces;

namespace realmCommander.Models
{
  public class Knight : IWeapon
  {
    public string Name { get; set; }
    public bool HasArmor { get; set; }
    public string WeaponType { get; set; }
    public bool LongRange { get; set; }

    public string GetWeaponItem()
    {
      return $"{WeaponType} --- {LongRange}";
    }
    public Knight(string name, string weaponType, bool longRange)
    {
      Name = name;
      HasArmor = true;
      WeaponType = weaponType;
      LongRange = longRange;
    }
  }
}