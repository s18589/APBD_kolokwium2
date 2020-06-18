using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2.Models;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballController : ControllerBase
    {
        private readonly IFootballDbService _context;

        public FootballController(IFootballDbService context)
        {
            _context = context;
        }

        [HttpGet("/api/championships/{id:int}/teams")]
        public IActionResult GetTeamsList(int championshipId)
        {
            IActionResult response;

            response = Ok(_context.GetTeamsList(championshipId));

            return response;
        }
    }
}