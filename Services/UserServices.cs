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
    public class UserServices : IUserRepository
    {
        //llamado del DbContext
        private readonly MyDbContext _context;

        public UserServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Users.AnyAsync(u => u.Id == id);
        }

        public async Task Delete(int id)
        {
            var user = await GetById(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetById(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}