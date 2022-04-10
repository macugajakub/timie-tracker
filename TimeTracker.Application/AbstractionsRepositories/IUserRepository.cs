using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTO;
using TimeTracker.Domain.Entieties;

namespace TimeTracker.Application.Abstraction.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<ApplicationsUser>> GetAllUsers();
        Task<UserAuthentcationResponse> AuthenticateUser(UserAuthentcationRequest userAuthentcationRequest);
    }
}
