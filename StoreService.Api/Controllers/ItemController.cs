using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreService.Application.Queries.GetItems;

namespace StoreService.Api.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route ("{ID}")]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetItemsQuery());
            return Ok(response);
        }

    }
}