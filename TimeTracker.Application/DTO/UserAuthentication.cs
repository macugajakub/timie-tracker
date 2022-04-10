using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Application.DTO
{
    public class UserAuthentcationRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class UserAuthentcationResponse
    {
        public bool LoggedIn { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<UserGroupDto> UserGroups { get; set; }

        public UserAuthentcationResponse(string login, string name, string surname, IEnumerable<UserGroupDto> userGroups)
        {
            LoggedIn = true;
            Login = login;
            Name = name;
            Surname = surname;
            UserGroups = userGroups;
        }

        public UserAuthentcationResponse()
        {
            LoggedIn = false;
            Login = null;
            Name = null;
            Surname = null;
            UserGroups = null;
        }
        
    }
}
