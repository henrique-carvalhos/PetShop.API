using PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Core.Repositories
{
    public interface IClientRepository
    {
        Task<Client> GetClientByIdAsync(int id);
        Task<List<Client>> GetAllClientsAsync();
        Task SaveChangesAsync();
        Task AddAsync(Client client);
    }
}
