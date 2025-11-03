using angular_crud.Application.Features.Items.Commands;
using angular_crud.Application.Features.Items.Commands.CreateItem;
using angular_crud.Application.Features.Items.Commands.DeleteItem;
using angular_crud.Application.Features.Items.Commands.UpdateItem;
using angular_crud.Application.Features.Items.Queries.GetAllItems;
using angular_crud.Application.Features.Items.Queries.GetItemById;
using angular_crud.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace angular_crud.Api.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetAll()
        {
            var items = await _mediator.Send(new GetAllItemsQuery());
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetById(int id)
        {
            var item = await _mediator.Send(new GetItemByIdQuery(id));
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Item>> Create([FromBody] CreateItemCommand command)
        {
            var item = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateItemCommand command)
        {
            if (id != command.Id) return BadRequest();
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteItemCommand { Id = id });
            return NoContent();
        }
    }
}
