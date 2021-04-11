using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetManagement.Interface;
using BetManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace BetManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        public IServices service;

        public ServiceController(IServices serviceInt)
        {
            service = serviceInt;
        }

        [HttpPost("/ CreateMatch")]
        public IActionResult CreateMatch(Match match)
        {
            var temp = service.CreateMatch(match.ID, match.Description, match.TeamA, match.TeamB, match.Sport);
            return Ok(temp);
        }

        [HttpPut("/ DeleteMatch")]
        public IActionResult DeleteMatch(Match match)
        {
            var temp = service.DeleteMatch(match.ID, match.Description, match.TeamA, match.TeamB, match.Sport);
            return Ok(temp);
        }

        [HttpPut("/ UpdateMatch")]
        public IActionResult UpdateMatch(Match match)
        {
            var temp = service.UpdateMatch(match.ID, match.Description, match.TeamA, match.TeamB, match.Sport);
            return Ok(temp);
        }

        [HttpPost("/ CreateOdd")]
        public IActionResult CreateOdd(MatchOdds matchOdds)
        {
            var temp = service.CreateOdd(matchOdds.ID, matchOdds.MatchId, matchOdds.Specifier, matchOdds.Odd);
            return Ok(temp);
        }

        [HttpPut("/ DeleteOdd")]
        public IActionResult DeleteOdd(MatchOdds matchOdds)
        {
            var temp = service.DeleteOdd(matchOdds.ID, matchOdds.MatchId, matchOdds.Specifier, matchOdds.Odd);
            return Ok(temp);
        }

        [HttpPut("/ UpdateOdd")]
        public IActionResult UpdateOdd(MatchOdds matchOdds)
        {
            var temp = service.UpdateOdd(matchOdds.ID, matchOdds.MatchId, matchOdds.Specifier, matchOdds.Odd);
            return Ok(temp);
        }
    }
}
