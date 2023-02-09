using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Core.Entities;

namespace PetShop.Infrastructure.Persistence.Configurations
{
    public class UsersConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
            .HasKey(p => p.IdUser);

            builder
                .HasOne(p => p.Address)
                .WithOne(p => p.User)
                .HasForeignKey<Address>(p => p.IdAddress);
        }
    }
}
