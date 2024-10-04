using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Models.Customer>> GetAllCustomersAsync();
        Task<Models.Customer> GetCustomerByIdAsync(int id);
        Task AddCustomerAsync(Models.Customer customer);
        Task UpdateCustomerAsync(Models.Customer customer);
        Task DeleteCustomerAsync(int id);        
    }
}