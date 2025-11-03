using angular_crud.Domain.Entities;
using MediatR;

namespace angular_crud.Application.Features.Items.Queries.GetAllItems
{
    public class GetAllItemsQuery : IRequest<IEnumerable<Item>> { }
}
