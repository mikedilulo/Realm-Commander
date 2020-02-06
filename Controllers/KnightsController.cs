using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using realmCommander.Models;
using realmCommander.Services;

namespace realmCommander.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class KnightsController : ControllerBase
  {
    private readonly KnightsService _ks;
    private readonly QuestsService _qs;

    public KnightsController(KnightsService ks, QuestsService qs)
    {
      _ks = ks;
      _qs = qs;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Knight>> Get()
    {
      try
      {
        return Ok(_ks.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Knight> Get(int id)
    {
      try
      {
        return Ok(_ks.Get(id));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}/quests")]
    public ActionResult<IEnumerable<Quest>> GetQuests(int id)
    {
      try
      {
        return Ok(_qs.GetByKnightId(id));

      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Knight> Create([FromBody] Knight knightData)
    {
      try
      {
        return Ok(_ks.Create(knightData));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Knight> Edit([FromBody] Knight update, int id)
    {
      try
      {
        update.Id = id;
        return Ok(_ks.Edit(update));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<String> Delete(int id)
    {
      try
      {
        return Ok(_ks.Delete(id));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

  }
}