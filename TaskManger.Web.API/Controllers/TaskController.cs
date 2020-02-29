using Microsoft.AspNetCore.Mvc;

namespace TaskManger.Web.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("You have 12 tasks today");
        }
    }
}