using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task Add(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Orders.AnyAsync(o => o.Id == id);
        }

        public async Task Delete(int id)
        {
            var order = await GetById(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order?> GetById(int id)
        {
            return await _context.Orders.FindAsync(id);
        }
    }
}