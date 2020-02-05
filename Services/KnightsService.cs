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

    internal Knight Create(Knight knightData)
    {
      _repo.Create(knightData);
      return knightData;
    }

    internal Knight Edit(Knight update)
    {
      var exists = _repo.GetById(update.Id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _repo.Edit(update);
      return update;

    }

    internal string Delete(int id)
    {
      var exists = _repo.GetById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _repo.Delete(id);
      return "Successfully Deleted";
    }
  }
}