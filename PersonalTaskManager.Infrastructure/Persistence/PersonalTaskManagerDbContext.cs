using Microsoft.EntityFrameworkCore;
using PersonalTaskManager.Core.Models;

namespace PersonalTaskManager.Infrastructure.Persistence
{
    public class PersonalTaskManagerDbContext : DbContext
    {
        public PersonalTaskManagerDbContext(DbContextOptions options) : base(options)
        {
        }

        public PersonalTaskManagerDbContext()
        {
        }

        public DbSet<PersonalTask> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
