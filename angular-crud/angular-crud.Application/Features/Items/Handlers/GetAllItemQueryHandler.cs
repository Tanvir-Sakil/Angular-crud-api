using angular_crud.Domain.Entities;
using angular_crud.Domain.Repositories;
using MediatR;

namespace angular_crud.Application.Features.Items.Queries.GetAllItems
{
    public class GetAllItemsQueryHandler : IRequestHandler<GetAllItemsQuery, IEnumerable<Item>>
    {
        private readonly IItemRepository _itemRepository;

        public GetAllItemsQueryHandler(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IEnumerable<Item>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            return await _itemRepository.GetAllAsync();
        }
    }
}
