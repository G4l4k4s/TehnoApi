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

        public async Task Add(OrderItem orderItem)
        {
            await _context.OrderItems.AddAsync(orderItem);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.OrderItems.AnyAsync(x => x.Id == id);
        }

        public async Task Delete(int id)
        {
            var orderItem = await GetById(id);
            if (orderItem != null)
            {
                _context.OrderItems.Remove(orderItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<OrderItem>> GetAll()
        {
            return await _context.OrderItems.ToListAsync();
        }

        public async Task<OrderItem?> GetById(int id)
        {
            return await _context.OrderItems.FindAsync(id);
        }
    }
}