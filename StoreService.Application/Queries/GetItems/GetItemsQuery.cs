using MediatR;
using StoreService.Core.Responses;

namespace StoreService.Application.Queries.GetItems
{
    public record GetItemsQuery() : IRequest<List<ItemResponse>>;
}
