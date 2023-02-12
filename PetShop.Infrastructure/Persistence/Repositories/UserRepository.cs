using Microsoft.EntityFrameworkCore;
using PetShop.Core.Entities;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PetShopDbContext _dbContext;
        public UserRepository(PetShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(p => p.IdUser == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
