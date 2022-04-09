using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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
            var a = await _query.GetAllUsers();
            return Ok(a);
        }
    }
}
