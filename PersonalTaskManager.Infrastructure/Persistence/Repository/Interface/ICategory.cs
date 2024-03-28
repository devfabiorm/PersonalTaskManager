using PersonalTaskManager.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalTaskManager.Infrastructure.Persistence.Repository.Interface
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategories();
        Task<Category> GetById(int id);
    }
}
