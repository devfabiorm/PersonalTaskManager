using PersonalTaskManager.Core.Models;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Implementation;
using System.Threading.Tasks;

namespace PersonalTaskManager.Application.Commands.CreateTask
{
    public class CreateTaskCommandHandler
    {
        private readonly TaskRepository _taskRepository;

        public CreateTaskCommandHandler()
        {
            _taskRepository = new TaskRepository();
        }

        public async Task<int> Handle(CreateTaskCommand request)
        {
            var task = new PersonalTask(request.Title, request.LimitDate, request.CategoryId, request.Details);

            await _taskRepository.CreateAsync(task);

            return task.Id;
        }
    }
}
