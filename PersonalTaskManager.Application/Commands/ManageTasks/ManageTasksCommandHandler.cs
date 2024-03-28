using MediatR;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Implementation;
using System.Threading;
using System.Threading.Tasks;

using System.Linq;

namespace PersonalTaskManager.Application.Commands.ManageTasks
{
    public class ManageTasksCommandHandler : IRequestHandler<ManageTasksCommand, Unit>
    {
        private readonly TaskRepository _taskRepository;

        public ManageTasksCommandHandler()
        {
            //_taskRepository = new TaskRepository();
        }

        public Task<Unit> Handle(ManageTasksCommand request, CancellationToken cancellationToken)
        {
           var tasks = _taskRepository
                .GetAll(x => x.LimitDate <= request.CurrentDate && x.Status != Core.Enums.ETaskStatus.Finished)
                .ToList();

            tasks.ForEach(x => x.Status = Core.Enums.ETaskStatus.Overdue);

            _taskRepository.Update(tasks.ToArray());

            return Unit.Task;
        }
    }
}
