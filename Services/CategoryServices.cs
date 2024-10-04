using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TechStoreApi.Data;
using TechStoreApi.Models;
using TechStoreApi.Repository;

namespace TechStoreApi.Services
{
    public class CategoryServices : ICategoryRepository
    {
        private readonly MyDbContext _context;

        public CategoryServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Category category)
        {
            await _context.Categorys.AddAsync(category);
            await _context.SaveChangesAsync();            
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Categorys.AnyAsync(c => c.Id == id);
        }

        public async Task Delete(int id)
        {
            var category = await GetById(id);
            if (category != null)
            {
                _context.Categorys.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categorys.ToListAsync();
        }

        public async Task<Category?> GetById(int id)
        {
            return await _context.Categorys.FindAsync(id);
        }
    }
}