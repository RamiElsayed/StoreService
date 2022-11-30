using StoreService.Infrastructure.Entities;

namespace StoreService.Application.Queries
{
    public record ItemsResponse(List<ItemEntity> Items);
}
