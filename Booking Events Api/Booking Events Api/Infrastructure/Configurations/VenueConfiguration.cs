using Booking_Events_API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Booking_Events_API.Infrastructure.Configurations
{
    public class VenueConfiguration : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.CompanyId).IsRequired();

            builder.HasOne(v => v.Company)
                   .WithMany(c => c.Venues)
                   .HasForeignKey(v => v.CompanyId)
                   .HasPrincipalKey(c => c.TaxId)
                   .OnDelete(DeleteBehavior.NoAction); // <- CLAVE
        }
    }


}
