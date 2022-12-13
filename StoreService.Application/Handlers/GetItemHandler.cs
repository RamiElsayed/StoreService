using MediatR;
using StoreService.Core.Queries;
using StoreService.Core.Responses;
using StoreService.Infrastructure.Repositories;

namespace StoreService.Application.Handlers
{
    public class GetItemHandler : IRequestHandler<GetItemQuery, ItemResponse>
    {
        private IItemRepository _repository;
        public GetItemHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ItemResponse> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            var item = await _repository.Get(request);
            return item;
        }
    }
}
