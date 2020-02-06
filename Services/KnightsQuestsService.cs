using System;
using realmCommander.Models;
using realmCommander.Repositories;

namespace realmCommander.Services
{
  public class KnightsQuestsService
  {
    private readonly KnightsQuestsRepository _repo;
    public KnightsQuestsService(KnightsQuestsRepository kr)
    {
      _repo = kr;
    }
    internal void Create(KnightQuest newData)
    {
      KnightQuest exists = _repo.Find(newData);
      if (exists != null) { throw new Exception("Knight already on Quest"); }
      _repo.Create(newData);
    }

    internal string Delete(KnightQuest kqs)
    {
      KnightQuest exists = _repo.Find(kqs);
      if (exists == null) { throw new Exception("Invalid ID combination"); }
      _repo.Delete(exists.Id);
      return "Successfully Deleted";
    }
  }
}