using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Entieties;
using TimeTracker.Domain.Repository;

namespace TimeTracker.Infrastructure.DAL.InMemory
{
    public class UserRepository : IUserRepository
    {
        private readonly Context_TimeTracker _context;

        public UserRepository(Context_TimeTracker context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
