using angular_crud.Domain.Repositories;
using MediatR;

namespace angular_crud.Application.Features.Items.Commands.UpdateItem
{
    public class UpdateItemCommandHandler : IRequestHandler<UpdateItemCommand, Unit>
    {
        private readonly IItemRepository _itemRepository;

        public UpdateItemCommandHandler(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<Unit> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
        {
            var item = await _itemRepository.GetByIdAsync(request.Id);
            if (item == null) return Unit.Value;

            item.Name = request.Name;
            item.Category = request.Category;
            item.Brand = request.Brand;

            await _itemRepository.UpdateAsync(item);
            return Unit.Value;
        }
    }
}
