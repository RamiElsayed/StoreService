using MediatR;
using StoreService.Infrastructure.Repositories;

namespace StoreService.Application.Queries.GetItems
{
    public class GetItemsHandler : IRequestHandler<GetItemsQuery, ItemsResponse?>
    {
        private IItemRepository _repository;
        public GetItemsHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ItemsResponse?> Handle(GetItemsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
