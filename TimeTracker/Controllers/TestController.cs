using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TimeTracker.Application.DTO;
using TimeTracker.Application.Services;

namespace TimeTracker.API.Controllers
{
    public class TestController : BaseController
    {
        private readonly ITestService _testService;

        public TestController(ITestService usersService)
        {
            _testService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var a = await _testService.GetAsync();
            return Ok(a);
        }
    }
}
