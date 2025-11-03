using angular_crud.Domain;
using angular_crud.Domain.Repositories;
using MediatR;

namespace angular_crud.Application.Features.Items.Queries.GetItemById
{
    public class GetItemByIdQueryHandler : IRequestHandler<GetItemByIdQuery, Item?>
    {
        private readonly IItemRepository _itemRepository;

        public GetItemByIdQueryHandler(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<Item?> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
        {
            return await _itemRepository.GetByIdAsync(request.Id);
        }
    }
}
