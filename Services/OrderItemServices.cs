using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStoreApi.Data;
using TechStoreApi.Models;
using TechStoreApi.Repository;

namespace TechStoreApi.Services
{
    public class OrderItemServices : IOrderItemRepository
    {

        private readonly MyDbContext _context;

        public OrderItemServices(MyDbContext context)
        {
            _context = context;
        }

        public Task<OrderItem> AddOrderItemAsync(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> GetOrderItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderItem>> GetOrderItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> UpdateOrderItemAsync(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}