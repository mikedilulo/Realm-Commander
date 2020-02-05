namespace realmCommander.Interfaces
{
  interface IWeapon
  {
    public string WeaponType { get; set; }
    public string KnightClass { get; set; }

    string GetWeaponItem();
  }
}