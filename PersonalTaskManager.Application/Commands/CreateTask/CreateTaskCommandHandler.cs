﻿using Microsoft.Extensions.Logging;
using PersonalTaskManager.Core.Models;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Implementation;
using System.Threading.Tasks;

namespace PersonalTaskManager.Application.Commands.CreateTask
{
    public class CreateTaskCommandHandler
    {
        private readonly TaskRepository _taskRepository;
        private readonly ILogger _logger;

        public CreateTaskCommandHandler()
        {
            _taskRepository = new TaskRepository();
            _logger = new LoggerFactory().CreateLogger<CreateTaskCommandHandler>();
        }

        public async Task<int> Handle(CreateTaskCommand request)
        {
            var task = new PersonalTask
            {
                Title = request.Title,
                Description = request.Details,
                Category = request.Category,
                LimitDate = request.LimitDate,
                Status = Core.Enums.ETaskStatus.Created
            };

            _logger.LogInformation("Saving data");
            await _taskRepository.CreateAsync(task);

            return task.Id;
        }
    }
}
