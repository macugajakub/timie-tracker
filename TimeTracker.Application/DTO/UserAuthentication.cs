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
}
