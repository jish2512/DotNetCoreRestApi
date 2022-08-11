using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreRestApi.BusinessManager;
using DotNetCoreRestApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
      
        private readonly IUserDetails _userDetails;
        public UserController(IUserDetails userDetails)
        {
            _userDetails=userDetails;
            
        }
        [HttpGet]
        public ActionResult<IEnumerable<UserData>> GetAll()
        {
            return Ok(_userDetails.FetchUsers());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult< UserData> GetById(int id)
        {
            return Ok(_userDetails.GetUserById(id));
        }

        //// POST api/<ValuesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
