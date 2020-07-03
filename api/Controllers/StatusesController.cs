using api.DAL;
using api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace api.Controllers
{
    [Route("api/statuses/neptun")] // REPLACE neptun WITH YOUR NEPTUN CODE SMALL CAPS - CSERELD LE A neptun-t a SAJAT NEPTUN KODODRA KISBETUKKEL
    [ApiController]
    public class StatusesController : ControllerBase
    {
        private readonly IStatusesRepository repository;

        // DO NOT CHANGE THE CONSTRUCTOR - NE VALTOZTSD MEG A KONSTRUKTORT
        public StatusesController(IStatusesRepository repository)
        {
            this.repository = repository;
        }
    }
}
