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
    public class AddressRepository : IAddressRepository
    {
        private readonly PetShopDbContext _dbContext;
        public AddressRepository(PetShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Address address)
        {
            await _dbContext.Addresses.AddAsync(address);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Address> GetAddressById(int id)
        {
            return await _dbContext.Addresses
                .Include(p => p.Client)
                .SingleOrDefaultAsync(p => p.IdAddress == id);
        }

        public async Task<List<Address>> GetAllAddresses()
        {
            return await _dbContext.Addresses
                .Include(p => p.Client)
                .ToListAsync();
        }

        public async Task SavaChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
