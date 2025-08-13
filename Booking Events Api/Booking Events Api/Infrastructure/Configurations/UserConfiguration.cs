using Booking_Events_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Events_API.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserName);

            builder.HasOne(u => u.Person)
                   .WithMany() // o .WithMany(p => p.Users) si agregas la colección
                   .HasForeignKey(u => u.PersonId)
                   .HasPrincipalKey(p => p.DniNumber)
                   .OnDelete(DeleteBehavior.NoAction); // <- CLAVE
        }
    }

}
