using PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Core.Repositories
{
    public interface IAddressRepository
    {
        Task<Address> GetAddressById(int id);
        Task<List<Address>> GetAllAddresses();
    }
}
