using System;
using Microsoft.AspNetCore.Mvc;
using realmCommander.Models;
using realmCommander.Services;

namespace realmCommander.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class KnightsQuestsController : ControllerBase
  {
    private readonly KnightsQuestsService _kq;
    public KnightsQuestsController(KnightsQuestsService kq)
    {
      _kq = kq;
    }

    [HttpPost]
    public ActionResult<String> Create([FromBody] KnightQuest newData)
    {
      try
      {
        _kq.Create(newData);
        return Ok("Success");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("/removeKnight")]
    public ActionResult<String> Edit([FromBody] KnightQuest kqs)
    {
      try
      {
        return Ok(_kq.Delete(kqs));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}