using StoreService.Core.Queries;
using StoreService.Core.Responses;
using StoreService.Infrastructure.Entities;

namespace StoreService.Infrastructure.Repositories
{
    public interface IItemRepository
    {
        Task<List<ItemResponse>> GetAll();
        Task<ItemResponse> Get(GetItemQuery query);
    }
}
