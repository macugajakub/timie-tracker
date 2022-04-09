using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTO;
using TimeTracker.Domain.Repository;

namespace TimeTracker.Application.User
{
    public class UserQuery : IUserQuery
    {
        private readonly IUserRepository _userRepository;

        public UserQuery(IUserRepository repo)
        {
            _userRepository = repo;
        }

        public Task<IEnumerable<Domain.Entieties.User>> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}
