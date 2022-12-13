using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreService.Core.Queries;

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
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetItemsQuery());
            return Ok(response);
        }

        [HttpGet]
        [Route("{productId}")]
        public async Task<IActionResult> Get(Guid productId)
        {
            var response = await _mediator.Send(new GetItemQuery(productId));
            return Ok(response);
        }

    }
}