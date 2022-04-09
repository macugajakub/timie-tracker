using AutoMapper;
using TimeTracker.Application.DTO;
using TimeTracker.Domain.Entieties;

namespace TimeTracker.API
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<ApplicationsUser, UserDto>();
        }

    }
}
