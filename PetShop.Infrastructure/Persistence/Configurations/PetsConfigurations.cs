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
    public class PetsConfigurations : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder
            .HasKey(p => p.IdPet);

            builder
                .HasMany(p => p.Consultations)
                .WithOne(p => p.Pet)
                .HasForeignKey(p => p.IdPet)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.User)//um user tem
                .WithMany(p => p.Pets)// uma lista de pets
                .HasForeignKey(p => p.IdUser)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
