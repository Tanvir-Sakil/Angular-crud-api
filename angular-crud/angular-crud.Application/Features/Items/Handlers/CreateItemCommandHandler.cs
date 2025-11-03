using angular_crud.Domain.Entities;
using angular_crud.Domain.Repositories;
using MediatR;

namespace angular_crud.Application.Features.Items.Commands.CreateItem
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, Item>
    {
        private readonly IItemRepository _itemRepository;

        public CreateItemCommandHandler(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<Item> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var item = new Item
            {
                Name = request.Name,
                Category = request.Category,
                Brand = request.Brand,
                inStock = request.inStock,
                DateAdded = request.DateAdded,
            };

            return await _itemRepository.CreateAsync(item);
        }
    }
}
