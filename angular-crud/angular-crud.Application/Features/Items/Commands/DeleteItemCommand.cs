using MediatR;

namespace angular_crud.Application.Features.Items.Commands.DeleteItem
{
    public class DeleteItemCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
