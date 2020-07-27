using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListOfTodos.Shared;
using Microsoft.AspNetCore.Mvc;
using OakIdeas.GenericRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListOfTodos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        IGenericRepository<TodoItem> TodoRepository;

        public TodoController(IGenericRepository<TodoItem> todoRepository)
        {
            TodoRepository = todoRepository;
        }

        // GET: api/<TodoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> Get()
        {
            var todos = await TodoRepository.Get(orderBy: todos => todos.OrderBy(t => t.DueDate));
            return Ok(todos);

        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetAsync(int id)
        {
            var todos = await TodoRepository.Get(filter: todos => todos.ID == id);
            
            return Ok(todos.FirstOrDefault());
        }

        // POST api/<TodoController>
        [HttpPost]
        public async Task<ActionResult<TodoItem>> Post([FromBody] TodoItem todoItem)
        {
            var newTodoItem = await TodoRepository.Insert(todoItem);
            return Ok(newTodoItem);

        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<TodoItem>> Put([FromBody] TodoItem todoItem)
        {
            var updated = await TodoRepository.Update(todoItem);
            return Ok(updated);
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await TodoRepository.Delete(id);
            return Ok();
        }
    }
}
