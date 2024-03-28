using MediatR;
using PersonalTaskManager.Application.ViewModels;

namespace PersonalTaskManager.Application.Queries.GetTaskById
{
    public class GetTaskByIdQuery : IRequest<PersonalTaskViewModel>
    {
        public int TaskId { get; set; }
    }
}
