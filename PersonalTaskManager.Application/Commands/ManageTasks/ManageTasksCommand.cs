using MediatR;
using System;

namespace PersonalTaskManager.Application.Commands.ManageTasks
{
    public class ManageTasksCommand : IRequest<Unit>
    {
        public ManageTasksCommand()
        {
            CurrentDate = DateOnly.FromDateTime(DateTime.Now);
        }

        public DateOnly CurrentDate { get; set; }
    }
}
