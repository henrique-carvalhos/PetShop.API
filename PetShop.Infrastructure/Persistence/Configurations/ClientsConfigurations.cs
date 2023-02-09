using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
    public class ClientsConfigurations : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
            .HasKey(p => p.IdClient);

            builder
                .HasOne(p => p.User)
                .WithMany(p => p.Clients)
                .HasForeignKey(p => p.IdUser)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Pets)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Addresses)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Consultations)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
