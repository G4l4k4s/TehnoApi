using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreApi.Models;

namespace TechStoreApi.Repository
{
    public interface IOrderItemRepository
    {
        Task<IEnumerable<OrderItem>> GetAll();
        Task<OrderItem?> GetById(int id);
        Task Add(OrderItem orderItem);
        Task Delete(int id);
        Task<bool> CheckExistence(int id); 
    }
}