using Booking_Events_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Events_API.Infrastructure.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.TaxId);
            builder.HasOne(c => c.Person)
            .WithMany()
            .HasForeignKey(c => c.LegalRepresentative) 
            .HasPrincipalKey(p => p.DniNumber)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
