using OwingBeersAPI.Context;
using OwingBeersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwingBeersAPI.Repository
{
    public class BeerRepository: IBeerRepository
    {

        private readonly IContextDB _context;

        public BeerRepository(IContextDB context)
        {
            _context = context;
        }

        public async Task AddBeer(Beer beer)
        {
            await _context.Beers.AddAsync(beer);
            await _context.SaveChangesAsync();

        }

    }
}
