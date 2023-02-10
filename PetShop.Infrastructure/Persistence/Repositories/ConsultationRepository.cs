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
    public class ConsultationRepository : IConsultationRepository
    {
        private readonly PetShopDbContext _dbContext;
        public ConsultationRepository(PetShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Consultation consultation)
        {
            await _dbContext.Consultations.AddAsync(consultation);
        }

        public async Task<List<Consultation>> GetAllConsultationAsync()
        {
            return await _dbContext.Consultations
                .Include(p => p.Client)
                .Include(p => p.Pet)
                .ToListAsync();
        }

        public async Task<Consultation> GetConsultationByIdAsync(int id)
        {
            return await _dbContext.Consultations
                .Include(p => p.Client)
                .Include(p => p.Pet)
                .SingleOrDefaultAsync(p => p.IdConsultation == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
