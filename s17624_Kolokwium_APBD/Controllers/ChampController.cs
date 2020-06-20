using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using s17624_Kolokwium_APBD.Services;

namespace s17624_Kolokwium_APBD.Controllers
{
    [Route("api/championships")]
    [ApiController]

    

    public class ChampController : ControllerBase
    {
        private readonly IChampService _champService;

        public ChampController(IChampService service)
        {
            _champService = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetTeamsInfo(int id)
        {
            return Ok();// (_champService.getTeamsInfo(id));
        }


    }
}