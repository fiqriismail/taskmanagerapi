using Microsoft.AspNetCore.Mvc;
using TaskManager.Services.Interfaces;

namespace TaskManger.Web.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _service;

        public TodoController(ITodoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var todoList = _service.GetTodos();
            return Ok(todoList);
        }
    }
}