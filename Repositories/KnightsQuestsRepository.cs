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
    internal void Create(KnightQuest newData)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }

    internal KnightQuest Find(KnightQuest kqs)
    {
      string sql = "SELECT * FROM knightsquests WHERE (questId = @QuestId AND knightId = @KnightId)";
      return _db.QueryFirstOrDefault(sql, kqs);
    }
  }
}