using MediatR;
using Microsoft.AspNetCore.Mvc;
using University.Application.Features.Lectors.Commands.CreateLector;
using University.Application.Features.Lectors.Commands.DeleteLector;
using University.Application.Features.Lectors.Commands.UpdateLector;
using University.Application.Features.Lectors.Queries.GetLector;
using University.Application.Features.Lectors.Queries.GetLectorsList;

namespace University.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectorController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LectorController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("all", Name = "GetAllLectors")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<LectorListVm>>> GetAllLectors()
        {
            var dtos = await _mediator.Send(new GetLectorsListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LectorVm>> GetLectorById(Guid id)
        {
            var lectorQuery = new GetLectorQuery() { Id = id};
            return Ok(await _mediator.Send(lectorQuery));
        }

        [HttpPost(Name = "AddLector")]
        public async Task<ActionResult> Create([FromBody] CreateLectorCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateLector")]
        public async Task<ActionResult> Update([FromBody] UpdateLectorCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "RemoveLector")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteCommand = new DeleteLectorCommand() { Id = id };
            await _mediator.Send(deleteCommand);

            return NoContent();
        }
    }


}
