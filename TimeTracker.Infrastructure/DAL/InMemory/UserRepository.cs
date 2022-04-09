using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTO;
using TimeTracker.Domain.Entieties;
using TimeTracker.Application.Abstraction.Repository;


namespace TimeTracker.Infrastructure.DAL.InMemory
{
    public class UserRepository : IUserRepository
    {
        private readonly Context_TimeTracker _context;

        public UserRepository(Context_TimeTracker context)
        {
            _context = context;
        }

        public async Task<int> AuthenticateUser(UserAuthentcationRequest userAuthentcationRequest)
        {
            var user =await _context.Users.Where(e => e.Login.ToLower() == userAuthentcationRequest.Login.ToLower()).FirstOrDefaultAsync();

            if (user == null)
                return -1;

            return user.Id;
        }

        public async Task<IEnumerable<ApplicationsUser>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
