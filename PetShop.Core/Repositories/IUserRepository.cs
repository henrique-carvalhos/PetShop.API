using PetShop.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetShop.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<List<User>> GetAllUsersAsync();
        Task AddAsync(User user);
        Task SaveChangesAsync();
    }
}
