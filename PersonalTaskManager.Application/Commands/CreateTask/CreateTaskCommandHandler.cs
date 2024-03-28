using MediatR;
using PersonalTaskManager.Core.Models;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Implementation;
using System.Threading;
using System.Threading.Tasks;

namespace PersonalTaskManager.Application.Commands.CreateTask
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, int>
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly TaskRepository _taskRepository;

        public CreateTaskCommandHandler()
        {
            _categoryRepository = new CategoryRepository();
            _taskRepository = new TaskRepository();
        }

        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetById(request.CategoryId);
            var personalTask = new PersonalTask(request.Title, request.LimitDate, category);

            await _taskRepository.CreateAsync(personalTask);

            return personalTask.Id;
        }
    }
}
