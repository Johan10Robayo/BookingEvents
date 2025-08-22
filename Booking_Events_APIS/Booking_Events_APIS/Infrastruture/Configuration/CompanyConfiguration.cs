using Booking_Events_APIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Events_APIS.Infrastruture.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.TaxId);

            builder.HasOne(c => c.Person)
            .WithMany(c => c.Companies)
            .HasForeignKey(c => c.LegalRepresentative)
            .HasPrincipalKey(p => p.DniNumber)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
