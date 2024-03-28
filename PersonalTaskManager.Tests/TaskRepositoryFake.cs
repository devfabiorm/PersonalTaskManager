using PersonalTaskManager.Core.Models;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTaskManager.Tests
{
    public class TaskRepositoryFake : ITaskRepository
    {
        private readonly List<PersonalTask> _tasks = new List<PersonalTask>();

        public async Task CreateAsync(PersonalTask task)
        {
            task.Id = 1;
            await Task.FromResult(() => _tasks.Add(task));
        }

        public Task CreateAsync(params PersonalTask[] tasks)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonalTask> GetAll(Func<PersonalTask, bool> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(params PersonalTask[] tasks)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int taskId, string title, DateOnly limitDate)
        {
            throw new NotImplementedException();
        }
    }
}
