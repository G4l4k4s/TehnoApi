using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreApi.Models;

namespace TechStoreApi.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category?> GetById(int id);
        Task Add(Category category);
        Task Delete(int id);
        Task<bool> CheckExistence(int id);
    }
}