using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OwingBeersAPI.Models;
using OwingBeersAPI.Repository;
using OwingBeersAPI.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwingBeersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        //POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserRequest request)
        {

            var user = new User
            {
                Name = request.Name,
                Status = request.Status,
                BeerId = request.BeerId

            };

            await _userRepository.AddUser(user);
            return Ok();
        }


    }
}
