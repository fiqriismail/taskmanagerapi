using Microsoft.AspNetCore.Mvc;
using TaskManager.Services.Interfaces;
using TaskManger.ModelMappers;

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
        public IActionResult Get(string filter)
        {
            var a = filter;
            var todoList = _service.GetTodos();
            return Ok(todoList);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var todo = _service.GetTodo(id);
            if (todo == null)
                return BadRequest(new { message = "The id you have sent not found" });
            return Ok(todo);
        }

        [HttpPost]
        public IActionResult Post(TodoMapper mapper)
        {
            var index = _service.StoreTodo(mapper);
            if (index > 0)
            {
                return Ok(new { message = "Todo added to your list" });
            }
            return StatusCode(500, new { message = "Something went wrong" });
        }


        [HttpPut]
        public IActionResult Put(TodoMapper mapper)
        {
            var index = _service.StoreTodo(mapper);
            if (index > 0)
            {
                return Ok(new { message = "Todo updated to your list" });
            }
            return StatusCode(500, new { message = "Something went wrong" });
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Remove(id);
            return Ok("Deleted");
        }
    }
}