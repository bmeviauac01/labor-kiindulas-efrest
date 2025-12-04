using Microsoft.AspNetCore.Mvc;

namespace Datadriven.Lab.Rest.Controllers;

// DO NOT CHANGE ANYTHING!
// NE VALTOZTASS MEG SEMMIT!
[Route("api/[Controller]")]
[ApiController]
public class PingController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Ping()
    {
        return Ok("pong");
    }
}
