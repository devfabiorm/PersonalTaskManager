using PersonalTaskManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalTaskManager.Infrastructure.Persistence.Repository.Interface
{
    public interface ITaskRepository
    {
        Task CreateAsync(PersonalTask task);
        Task CreateAsync(params PersonalTask[] tasks);
        Task UpdateAsync(int taskId, string title, DateOnly limitDate);
        void Update(params PersonalTask[] tasks);
        Task DeleteByIdAsync(int taskId);
        IEnumerable<PersonalTask> GetAll(Func<PersonalTask, bool> filter);
    }
}
