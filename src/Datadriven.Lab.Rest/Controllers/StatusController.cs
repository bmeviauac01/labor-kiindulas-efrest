using Datadriven.Lab.Rest.Services;

using Microsoft.AspNetCore.Mvc;

namespace Datadriven.Lab.Rest.Controllers;

// TODO: REPLACE neptun WITH YOUR NEPTUN CODE SMALL CAPS
// TODO: CSERELD LE A neptun-t a SAJAT NEPTUN KODODRA KISBETUKKEL
[Route("api/[controller]/neptun")]
[ApiController]
public class StatusController : ControllerBase
{
    private readonly IStatusService _statusService;

    // DO NOT CHANGE THE CONSTRUCTOR!
    // NE VALTOZTSD MEG A KONSTRUKTORT!
    public StatusController(IStatusService statusService)
    {
        _statusService = statusService;
    }
}
