using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreApi.Data;
using TechStoreApi.Models;
using TechStoreApi.Repository;

namespace TechStoreApi.Services
{
    public class OrderServices : IOrderRepository
    {

        private readonly MyDbContext _context;

        public OrderServices(MyDbContext context)
        {
            _context = context;
        }

        public Task<Order> AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderByCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderWithCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderWithDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderWithItems(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderWithItemsAndCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}