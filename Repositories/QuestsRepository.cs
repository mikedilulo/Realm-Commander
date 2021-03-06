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

    internal void Edit(Quest update)
    {
      string sql = @"
      UPDATE quests
      SET
      title = @Title,
      description = @Description,
      completed = @Completed
      WHERE id = @Id
       ";
      _db.Execute(sql, update);

    }

    internal IEnumerable<Quest> GetQuestsByKnightId(int knightId)
    {
      string sql = @"
      SELECT q.*
      FROM knightsquests qs
      JOIN quests q ON q.id = qs.questId
      WHERE knightId = @KnightId";

      return _db.Query<Quest>(sql, new { knightId });
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM quests WHERE id = @Id";
      _db.Execute(sql, new { id });
    }
  }
}