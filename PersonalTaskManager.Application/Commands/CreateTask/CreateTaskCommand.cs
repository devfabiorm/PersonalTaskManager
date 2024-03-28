using MediatR;
using System;

namespace PersonalTaskManager.Application.Commands.CreateTask
{
    public class CreateTaskCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string  Details { get; set; }
        public DateOnly LimitDate { get; set; }
        public int CategoryId { get; set; }
    }
}
