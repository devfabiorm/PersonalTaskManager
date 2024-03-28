using MediatR;
using PersonalTaskManager.Core.Models;
using System;

namespace PersonalTaskManager.Application.Commands.CreateTask
{
    public class CreateTaskCommand
    {
        public CreateTaskCommand(string title, string details, DateOnly limitDate, Category categoryId)
        {
            Title = title;
            Details = details;
            LimitDate = limitDate;
            Category = categoryId;
        }

        public string Title { get; }
        public string  Details { get; }
        public DateOnly LimitDate { get; }
        public Category Category { get; }
    }
}
