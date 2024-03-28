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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PersonalTaskDb;Trusted_Connection=true");
        }

        public DbSet<PersonalTask> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
