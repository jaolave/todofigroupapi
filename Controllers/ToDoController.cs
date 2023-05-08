using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoFiGroupApi.Interfaces;
using ToDoFiGroupApi.Models;

namespace ToDoFiGroupApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoRepository _repository;

        public ToDoController(IToDoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoItem>>> Get()
        {
            return Ok(await _repository.GetAllAsync());
        }

        [HttpGet("{uid}")]
        public async Task<ActionResult<ToDoItem>> Get(Guid uid)
        {
            var toDoItem = await _repository.GetByIdAsync(uid);
            if (toDoItem == null) return NotFound();

            return Ok(toDoItem);
        }

        [HttpPost]
        public async Task<ActionResult<ToDoItem>> Post(ToDoItem toDoItem)
        {
            await _repository.AddAsync(toDoItem);
            return CreatedAtAction(nameof(Get), new { uid = toDoItem.UID }, toDoItem);
        }

        [HttpPut("{uid}")]
        public async Task<IActionResult> Put(Guid uid, ToDoItem toDoItem)
        {
            if (uid != toDoItem.UID) return BadRequest();

            await _repository.UpdateAsync(toDoItem);
            return NoContent();
        }

        [HttpDelete("{uid}")]
        public async Task<IActionResult> Delete(Guid uid)
        {
            await _repository.DeleteAsync(uid);
            return NoContent();
        }
    }

}
