using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTO;
using TimeTracker.Application.Abstraction.Repository;


namespace TimeTracker.Application.User
{
    public class UserQuery : IUserQuery
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;


        public UserQuery(IUserRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = repo;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            var user = await _userRepository.GetAllUsers();
            return _mapper.Map<IEnumerable<UserDto>>(user);
        }
    }
}
