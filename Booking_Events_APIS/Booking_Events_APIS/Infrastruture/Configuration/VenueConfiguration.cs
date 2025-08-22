using Booking_Events_APIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Events_APIS.Infrastruture.Configuration
{
    public class VenueConfiguration : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {

            builder.Property(v => v.CompanyTaxId).IsRequired();

            builder.HasOne(v => v.Company)
                   .WithMany(c => c.Venues)
                   .HasForeignKey(v => v.CompanyTaxId)
                   .HasPrincipalKey(c => c.TaxId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
