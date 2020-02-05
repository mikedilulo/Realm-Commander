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
  }
}