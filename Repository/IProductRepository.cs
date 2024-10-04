using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreApi.Models;

namespace TechStoreApi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product?> GetById(int id);
        Task Add(Product product);
        Task Delete(int id);
        Task<bool> CheckExistence(int id);
    }
}