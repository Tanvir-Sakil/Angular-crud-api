using angular_crud.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angular_crud.Application.Features.Categories.Queries
{
    public class GetAllCategoriesQuery : IRequest<IEnumerable<Category>> { }

}
