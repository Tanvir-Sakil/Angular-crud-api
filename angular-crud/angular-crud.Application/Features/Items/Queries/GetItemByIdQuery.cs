using angular_crud.Domain.Entities;
using MediatR;

namespace angular_crud.Application.Features.Items.Queries.GetItemById
{
    public class GetItemByIdQuery : IRequest<Item?>
    {
        public int Id { get; set; }
        public GetItemByIdQuery(int id) => Id = id;
    }
}
