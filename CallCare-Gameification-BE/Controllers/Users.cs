using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using CallCare_Gameification_BE.Classes;
using System;
using System.Configuration;
using CallCare_Gameification_BE.DB;
using Microsoft.Extensions.Configuration;
using System.Net;


namespace CallCare_Gameification_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly callcareDB _context;
        private UserFunctions _userFunctions;

        public UsersController(callcareDB context) {
            _context = context;
            _userFunctions = new UserFunctions(_context);
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserDetails(int id)
        {
            (ErrorHandleing a, Models.User b) = _userFunctions.getUser(id);
            return StatusCode((int)a._Status, b);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetUserBadges(int id)
        //{

        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetUsers(int id)
        //{

        //}


        // POST api/<Users>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
