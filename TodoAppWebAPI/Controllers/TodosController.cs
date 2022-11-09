using Microsoft.AspNetCore.Mvc;
using TodoAppDomain.Model;
using TodoAppRepository.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        
        public TodosController(ITodoRepository todoService)
        {
            _todoService = todoService;
        }
        // GET: api/<TodosController>
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            var todoList = _todoService.All();
            return todoList;
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public Todo Get(int id)
        {
            var todo = _todoService.Find(id);
            return todo;
        }

        // POST api/<TodosController>
        [HttpPost]
        public void Post([FromBody] Todo value)
        {
            _todoService.Add(value);
        }

        // PUT api/<TodosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public void Delete(Todo value)
        {
            _todoService.Delete(value);
        }
    }
}
