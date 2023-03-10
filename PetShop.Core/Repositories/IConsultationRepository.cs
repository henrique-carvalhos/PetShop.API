using PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Core.Repositories
{
    public interface IConsultationRepository
    {
        Task<Consultation> GetConsultationByIdAsync(int id);
        Task<List<Consultation>> GetAllConsultationAsync();
        Task AddAsync(Consultation consultation);
        Task SaveChangesAsync();
    }
}
