using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Repository
{
    public interface IUserRepository
    {
        // CRUD operations for User entity
        Task<IEnumerable<Models.User>> GetAllUsersAsync();
        Task<Models.User> GetUserByIdAsync(int id);
        Task<Models.User> CreateUserAsync(Models.User user);
        Task<Models.User> UpdateUserAsync(Models.User user);
        Task DeleteUserAsync(int id);
    }
}