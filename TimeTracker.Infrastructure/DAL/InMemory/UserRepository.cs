using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTO;
using TimeTracker.Domain.Entieties;
using TimeTracker.Application.Abstraction.Repository;
using AutoMapper;

namespace TimeTracker.Infrastructure.DAL.InMemory
{
    public class UserRepository : IUserRepository
    {
        private readonly Context_TimeTracker _context;
        private readonly IMapper _mapper;

        public UserRepository(IMapper mapper ,Context_TimeTracker context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<UserAuthentcationResponse> AuthenticateUser(UserAuthentcationRequest userAuthentcationRequest)
        {
            var user =await _context.Users.Where(e => e.Login.ToLower() == userAuthentcationRequest.Login.ToLower()).FirstOrDefaultAsync();
            if (user == null)
                return new UserAuthentcationResponse();

            var correctPassword = user.Password == userAuthentcationRequest.Password;
            if(!correctPassword)
                return new UserAuthentcationResponse();
            
            //get groups 
            var userGroupsDic = _context.UserGroupDic.Where(e => e.UserId == user.Id).ToListAsync();
            var userGroups =  new List<UserGroupDto>();
            foreach (var userGroupDic in await userGroupsDic)
            {
                var userGroup = await _context.UserGroup.FirstOrDefaultAsync(e => e.Id == userGroupDic.GroupId);
                userGroups.Add(_mapper.Map<UserGroupDto>(userGroup));
            }


            return new UserAuthentcationResponse(user.Login, user.Name, user.Surname, userGroups);
        }



        public async Task<IEnumerable<ApplicationsUser>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
