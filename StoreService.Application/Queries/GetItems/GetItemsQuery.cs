using MediatR;

namespace StoreService.Application.Queries.GetItems
{
    public record GetItemsQuery() : IRequest<ItemsResponse?>;
}
