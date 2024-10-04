using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Models.Product>> GetAllProductsAsync();
        Task<Models.Product> GetProductByIdAsync(int id);
        Task<Models.Product> AddProductAsync(Models.Product product);   
        Task<Models.Product> UpdateProductAsync(Models.Product product);
        Task DeleteProductAsync(int id);       
    }
}