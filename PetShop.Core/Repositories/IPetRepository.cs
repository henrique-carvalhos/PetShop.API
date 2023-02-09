using PetShop.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetShop.Core.Repositories
{
    public interface IPetRepository
    {
        Task<Pet> GetByIdAsync(int id);
        Task<List<Pet>> GetAllPetsAsync();
        Task SaveChangesAsync();
        Task AddAsync(Pet pet);
    }
}
