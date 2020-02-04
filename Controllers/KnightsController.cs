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

    public KnightsController(KnightsService ks)
    {
      _ks = ks;
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
  }
}