using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using realmCommander.Models;
using realmCommander.Services;

namespace realmCommander.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class QuestsController : ControllerBase
  {
    private readonly QuestsService _qs;

    public QuestsController(QuestsService qs)
    {
      _qs = qs;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Quest>> Get()
    {
      try
      {
        return Ok(_qs.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Quest> Get(int id)
    {
      try
      {
        return Ok(_qs.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Quest> Create([FromBody] Quest questData)
    {
      try
      {
        return Ok(_qs.Create(questData));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


  }
}
