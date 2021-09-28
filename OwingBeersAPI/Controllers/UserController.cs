using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OwingBeersAPI.Models;
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
        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        
    }
}
