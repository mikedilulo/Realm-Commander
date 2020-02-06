using System;
using System.Data;
using Dapper;
using realmCommander.Models;

namespace realmCommander.Repositories
{

  public class KnightsQuestsRepository
  {
    private readonly IDbConnection _db;
    public KnightsQuestsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal KnightQuest Create(KnightQuest newData)
    {
      string sql = @"
      INSERT INTO knightsquests
      (knightId, questId)
      VALUES
      (@KnightId, @QuestId);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, newData);
      newData.Id = id;
      return newData;

    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM knightsquests WHERE id = @Id";
      _db.Execute(sql, new { id });
    }

    internal KnightQuest Find(KnightQuest kqs)
    {
      string sql = "SELECT * FROM knightsquests WHERE (questId = @QuestId AND knightId = @KnightId)";
      return _db.QueryFirstOrDefault(sql, kqs);
    }
  }
}