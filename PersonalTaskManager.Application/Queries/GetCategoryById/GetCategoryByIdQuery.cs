using MediatR;
using PersonalTaskManager.Core.Models;

namespace PersonalTaskManager.Application.Queries.GetCategoryById
{
    internal class GetCategoryByIdQuery : IRequest<Category>
    {
        public int CategoryId { get; set; }
    }
}
