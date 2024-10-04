using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreApi.Models;

namespace TechStoreApi.Repository
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task<Order> AddOrder(Order order);
        Task<Order> UpdateOrder(Order order);
        Task DeleteOrder(int id);
        Task<Order> GetOrderWithDetails(int id);
        Task<Order> GetOrderWithItems(int id);
        Task<Order> GetOrderWithCustomer(int id);
        Task<Order> GetOrderWithItemsAndCustomer(int id);
        Task<Order> GetOrderByCustomer(int customerId);       
    }
}