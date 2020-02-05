using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using realmCommander.Models;

namespace realmCommander.Repositories
{
  public class QuestsRepository
  {
    private readonly IDbConnection _db;
    public QuestsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Quest> Get()
    {
      string sql = "SELECT * FROM quests";
      return _db.Query<Quest>(sql);

    }

    internal Quest GetById(int id)
    {
      string sql = "SELECT * FROM quests WHERE id = @Id";
      return _db.QueryFirstOrDefault<Quest>(sql, new { id });
    }

    internal Quest Create(Quest questData)
    {
      string sql = @"INSERT INTO quests
      (title, description, completed)
      VALUES
      (@Title, @Description, @Completed);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, questData);
      questData.Id = id;
      return questData;
    }
  }
}