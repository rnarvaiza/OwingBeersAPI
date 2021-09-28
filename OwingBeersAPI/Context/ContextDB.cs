using Microsoft.EntityFrameworkCore;
using OwingBeersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwingBeersAPI.Context
{
    public class ContextDB : DbContext, IContextDB
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {

        }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
