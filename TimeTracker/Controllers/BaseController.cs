using Microsoft.AspNetCore.Mvc;

namespace TimeTracker.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}
