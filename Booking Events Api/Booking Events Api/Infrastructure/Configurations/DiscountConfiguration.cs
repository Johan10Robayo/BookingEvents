using Booking_Events_API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Booking_Events_API.Infrastructure.Configurations
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.CompanyId).IsRequired(); // string

            builder.HasOne(d => d.Company)
                   .WithMany() // o .WithMany(c => c.Discounts) si agregas nav inversa
                   .HasForeignKey(d => d.CompanyId)
                   .HasPrincipalKey(c => c.TaxId)
                   .OnDelete(DeleteBehavior.NoAction); // <- CLAVE
        }
    }

}
