using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using realmCommander.Models;

namespace realmCommander.Repositories
{
  public class KnightsRepository
  {
    private readonly IDbConnection _db;
    public KnightsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Knight> Get()
    {
      string sql = "SELECT * FROM knights";
      return _db.Query<Knight>(sql);

    }

    internal Knight GetById(int id)
    {
      string sql = "SELECT * FROM knights WHERE id = @id";
      return _db.QueryFirstOrDefault<Knight>(sql, new { id });
    }

    internal Knight Create(Knight knightData)
    {
      string sql = @"
      INSERT INTO knights
      (name, armorType, weaponType, knightClass)
      VALUES
      (@Name, @ArmorType, @WeaponType, @KnightClass);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, knightData);
      knightData.Id = id;
      return knightData;
    }

    internal void Edit(Knight update)
    {
      string sql = @"
      UPDATE knights
      SET
      name = @Name,
      armorType = @ArmorType,
      weaponType = @WeaponType,
      knightClass = @KnightClass
      WHERE id = @Id
      ";
      _db.Execute(sql, update);
    }

    internal void Delete(int id)
    {
      string sql = @"DELETE FROM knights WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}