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
    public class ProductServices : IProductRepository
    {

        private readonly MyDbContext _context;

        public ProductServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Products.AnyAsync(p => p.Id == id);
        }

        public async Task Delete(int id)
        {
            var product = await GetById(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}