using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreApi.Models;

namespace TechStoreApi.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer?> GetById(int id);
        Task Add(Customer customer);
        Task Delete(int id);
        Task<bool> CheckExistence(int id);      
    }
}