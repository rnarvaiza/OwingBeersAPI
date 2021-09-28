using OwingBeersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwingBeersAPI.Repository
{
    public interface IBeerRepository
    {
        Task AddBeer(Beer beer);
    }
}
