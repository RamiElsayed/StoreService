using MediatR;
using StoreService.Core.Responses;
using StoreService.Infrastructure.Repositories;

namespace StoreService.Application.Queries.GetItems
{
    public class GetItemsHandler : IRequestHandler<GetItemsQuery, List<ItemResponse>>
    {
        private IItemRepository _repository;
        public GetItemsHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ItemResponse>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
        {
            var items = await _repository.GetAll();
            return items;
        }
    }
}
