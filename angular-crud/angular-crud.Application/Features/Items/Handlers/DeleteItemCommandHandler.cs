using angular_crud.Domain.Repositories;
using MediatR;

namespace angular_crud.Application.Features.Items.Commands.DeleteItem
{
    public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand, Unit>
    {
        private readonly IItemRepository _itemRepository;

        public DeleteItemCommandHandler(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<Unit> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
        {
            await _itemRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}
