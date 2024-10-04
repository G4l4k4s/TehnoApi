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
    public class CustomerServices : ICustomerRepository
    {

        private readonly MyDbContext _context;

        public CustomerServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Customers.AnyAsync(c => c.Id == id);
        }

        public async Task Delete(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetById(int id)
        {
            return await _context.Customers.FindAsync(id);
        }
    }
}