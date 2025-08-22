using Booking_Events_APIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Events_APIS.Infrastruture.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserName);

            builder.HasOne(u => u.Person)
                   .WithMany(p => p.Users) // o .WithMany(p => p.Users) si agregas la colección
                   .HasForeignKey(u => u.PersonDniNumber)
                   .HasPrincipalKey(p => p.DniNumber)
                   .OnDelete(DeleteBehavior.NoAction); // <- CLAVE
        }
    }
}
