using MediatR;
using Microsoft.AspNetCore.Mvc;
using PersonalTaskManager.Application.Commands.CreateTask;
using PersonalTaskManager.Application.Queries.GetTaskById;

namespace PersonalTaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalTasksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonalTasksController(IMediator mediator)
        {
           _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetTaskByIdQuery { TaskId = id };

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateTaskCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id }, command);
        }
    }
}
