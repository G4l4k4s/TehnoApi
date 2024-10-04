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

        public async Task<Category> AddCategoryAsync(Category category)
        {
            _context.Categorys.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var DelCategory = await GetCategoryByIdAsync(id);
            if (DelCategory != null)
            {
                _context.Categorys.Remove(DelCategory);
                await _context.SaveChangesAsync();   
            }
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categorys.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
           return await _context.Categorys.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Category> UpdateCategoryAsync(Category category)
        {
            var FindCategory =  await GetCategoryByIdAsync(category.Id);
            if (FindCategory != null)
            {
                _context.Entry(FindCategory).CurrentValues.SetValues(category);
                await _context.SaveChangesAsync();
            }
            return category;

        }
    }
}