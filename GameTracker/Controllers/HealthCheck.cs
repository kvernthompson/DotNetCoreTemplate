using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
