using realmCommander.Interfaces;

namespace realmCommander.Models
{
  public class Knight : IWeapon
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string ArmorType { get; set; }
    public string WeaponType { get; set; }
    public string KnightClass { get; set; }

    public string GetWeaponItem()
    {
      return $"{WeaponType} --- {KnightClass}";
    }

    public Knight() { }
    public Knight(string name, string armorType, string weaponType, string knightClass)
    {
      Name = name;
      ArmorType = armorType;
      WeaponType = weaponType;
      KnightClass = knightClass;
    }
  }
}