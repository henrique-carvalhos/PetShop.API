using Microsoft.EntityFrameworkCore;
using PetShop.Core.Entities;
using PetShop.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Infrastructure.Persistence.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly PetShopDbContext _dbContext;
        public PetRepository(PetShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Pet pet)
        {
            await _dbContext.Pets.AddAsync(pet);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Pet>> GetAllPetsAsync()
        {
            return await _dbContext.Pets.ToListAsync();
        }

        public async Task<Pet> GetByIdAsync(int id)
        {
            return await _dbContext.Pets.SingleOrDefaultAsync(p => p.IdPet == id);
        }

        public Task SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
