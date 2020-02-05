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
      string sql = @"SELECT * FROM quests";
      return _db.Query<Quest>(sql);

    }
  }
}