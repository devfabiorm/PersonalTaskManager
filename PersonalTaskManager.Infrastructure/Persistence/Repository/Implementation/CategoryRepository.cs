using Microsoft.EntityFrameworkCore;
using PersonalTaskManager.Core.Models;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalTaskManager.Infrastructure.Persistence.Repository.Implementation
{
    public class CategoryRepository : ICategory
    {
        private readonly PersonalTaskManagerDbContext _context;

        public CategoryRepository()
        {
            _context = new PersonalTaskManagerDbContext();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public Task<Category> GetById(int id)
        {
            return _context.Categories.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
