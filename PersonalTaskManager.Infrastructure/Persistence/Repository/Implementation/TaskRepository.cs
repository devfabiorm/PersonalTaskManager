using Microsoft.EntityFrameworkCore;
using PersonalTaskManager.Core.Models;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalTaskManager.Infrastructure.Persistence.Repository.Implementation
{
    public class TaskRepository : ITaskRepository
    {
        private readonly PersonalTaskManagerDbContext _context;

        public TaskRepository(PersonalTaskManagerDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(PersonalTask task)
        {
            await _context.Tasks.AddAsync(task);
            _context.SaveChanges();
        }

        public async Task CreateAsync(params PersonalTask[] tasks)
        {
            await _context.Tasks.AddRangeAsync(tasks);
            _context.SaveChanges();
        }

        public async Task DeleteByIdAsync(int taskId)
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == taskId);

            if (task == null)
                return;

            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }

        public IEnumerable<PersonalTask> GetAll(Func<PersonalTask, bool> filter)
        {
            return _context.Tasks.Where(filter);
        }

        public async Task UpdateAsync(int taskId, string title, DateOnly limitDate)
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == taskId);

            if (task == null)
                return;

            task.Title = title;
            task.LimitDate = limitDate;

            _context.Update(task);
            _context.SaveChanges();
        }

        public void Update(params PersonalTask[] tasks)
        {
            _context.Tasks.UpdateRange(tasks);
            _context.SaveChanges();
        }
    }
}
