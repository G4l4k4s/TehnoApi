using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreApi.Models;

namespace TechStoreApi.Repository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order?> GetById(int id);
        Task Add(Order order);
        Task Delete(int id);
        Task<bool> CheckExistence(int id);
    }
}