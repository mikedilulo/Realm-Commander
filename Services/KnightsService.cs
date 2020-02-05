using System;
using System.Collections.Generic;
using realmCommander.Models;
using realmCommander.Repositories;

namespace realmCommander.Services
{
  public class KnightsService
  {

    private readonly KnightsRepository _repo;
    public KnightsService(KnightsRepository kr)
    {
      _repo = kr;
    }
    internal IEnumerable<Knight> Get()
    {
      return _repo.Get();
    }

    internal Knight Get(int id)
    {
      var exists = _repo.GetById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    }
  }
}