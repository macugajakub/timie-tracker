using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TimeTracker.Application.DTO;
using TimeTracker.Application.User;

namespace TimeTracker.API.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserQuery _query;

        public UsersController(IUserQuery query)
        {
            _query = query;
        }

        [HttpGet("All")]
        public async Task<ActionResult> GetAllUsers()
        {
            var result = await _query.GetAllUsers();
            return Ok(result);
        }

        [HttpPost("Login")]
        public async Task<ActionResult> AuthenticateUser([FromBody] UserAuthentcationRequest userAuthentcationRequest)
        {
            var result = await _query.AuthenticateUser(userAuthentcationRequest);
            return Ok(result);
        }
    }
}
