using OwingBeersAPI.Context;
using OwingBeersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwingBeersAPI.Repository
{
    public class UserRepository: IUserRepository
    {

        private readonly IContextDB _context;

        public UserRepository(IContextDB context)
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

        }

    }
}
