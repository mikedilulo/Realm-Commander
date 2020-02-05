using System;
using System.Collections.Generic;
using realmCommander.Models;
using realmCommander.Repositories;

namespace realmCommander.Services
{
  public class QuestsService
  {
    private readonly QuestsRepository _qreop;
    public QuestsService(QuestsRepository qr)
    {
      _qreop = qr;
    }
    internal IEnumerable<Quest> Get()
    {
      return _qreop.Get();
    }

    internal Quest GetById(int id)
    {
      var qexists = _qreop.GetById(id);
      if (qexists == null) { throw new Exception("Invalid Id"); }
      return qexists;
    }
  }
}