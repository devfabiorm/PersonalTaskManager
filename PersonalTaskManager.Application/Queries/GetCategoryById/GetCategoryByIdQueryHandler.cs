using MediatR;
using PersonalTaskManager.Core.Models;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Implementation;
using System.Threading;
using System.Threading.Tasks;

namespace PersonalTaskManager.Application.Queries.GetCategoryById
{
    internal class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, Category>
    {
        private readonly CategoryRepository _categoryRepository;

        public GetCategoryByIdQueryHandler()
        {
            _categoryRepository = new CategoryRepository();
        }

        public Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return _categoryRepository.GetById(request.CategoryId);
        }
    }
}
