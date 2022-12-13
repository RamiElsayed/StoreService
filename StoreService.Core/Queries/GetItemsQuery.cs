using MediatR;
using StoreService.Core.Responses;

namespace StoreService.Core.Queries
{
    public record GetItemsQuery() : IRequest<List<ItemResponse>>;
}
