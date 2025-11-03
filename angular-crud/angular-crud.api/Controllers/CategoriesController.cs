using angular_crud.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using angular_crud.Domain.Entities;
using angular_crud.Application.Features.Categories.Queries;

namespace angular_crud.Api.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            var categories = await _mediator.Send(new GetAllCategoriesQuery());
            return Ok(categories);
        }
    }
}
