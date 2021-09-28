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
    public class BeerController : ControllerBase
    {

        private readonly IBeerRepository _beerRepository;

        public BeerController(IBeerRepository beerRepository)
        {
            _beerRepository = beerRepository;
        }



        //POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]BeerRequest request )
        {

            var beer = new Beer
            {
                Name = request.Name,
                UntappdLink = request.UntappdLink

            };

           await _beerRepository.AddBeer(beer);
            return Ok();
        }

        
    }
}
