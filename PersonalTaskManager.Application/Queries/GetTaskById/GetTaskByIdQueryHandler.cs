using MediatR;
using PersonalTaskManager.Application.ViewModels;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PersonalTaskManager.Application.Queries.GetTaskById
{
    public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, PersonalTaskViewModel>
    {
        public Task<PersonalTaskViewModel> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
