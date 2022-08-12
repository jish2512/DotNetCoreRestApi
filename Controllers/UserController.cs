using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreRestApi.BusinessManager;
using DotNetCoreRestApi.DTO;
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
        private readonly IMapper _mapper;

        public UserController(IUserDetails userDetails, IMapper mapper)
        {
            _userDetails = userDetails;
            _mapper = mapper;

        }
        [HttpGet]
        public ActionResult<IEnumerable<UserDetailsReadDTO>> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<UserDetailsReadDTO>>(_userDetails.FetchUsers()));
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}",Name = "GetById")]
        public ActionResult<UserDetailsReadDTO> GetById(int id)
        {
            var userData = _userDetails.GetUserById(id);
            if (userData != null)
                return Ok(_mapper.Map<UserDetailsReadDTO>(userData));
            return NotFound(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult<UserDetailsReadDTO> CreateUserData(UserDetailsCreateDTO user)
        {
            var userdata = _mapper.Map<UserData>(user);
            _userDetails.CreateUserData(userdata);
            _userDetails.SaveChanges();
            var userDataDto = _mapper.Map<UserDetailsReadDTO>(userdata);

            return CreatedAtRoute(nameof(GetById),new { Id=userDataDto.ID},userDataDto);
        }

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
