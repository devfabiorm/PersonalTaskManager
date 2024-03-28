using MediatR;
using PersonalTaskManager.Core.Models;

namespace PersonalTaskManager.Application.Queries.GetTaskById
{
    public class GetTaskByIdQuery : IRequest<PersonalTask>
    {
        public int TaskId { get; set; }
    }
}
