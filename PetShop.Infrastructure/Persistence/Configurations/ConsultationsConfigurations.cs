using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Infrastructure.Persistence.Configurations
{
    public class ConsultationsConfigurations : IEntityTypeConfiguration<Consultation>
    {
        public void Configure(EntityTypeBuilder<Consultation> builder)
        {
            builder
                .HasKey(p => p.IdConsultation);

            builder
                .HasOne(p => p.Vet)
                .WithMany(p => p.Consultations)
                .HasForeignKey(p => p.IdVet)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
