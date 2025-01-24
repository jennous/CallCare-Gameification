using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using CallCare_Gameification_BE.Classes;
using System;
using System.Configuration;
using CallCare_Gameification_BE.DB;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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


        // GET: api/<Users>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // POST api/<Users>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //// PUT api/<Users>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<Users>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
