using Booking_Events_APIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Events_APIS.Infrastruture.Configuration
{
    public class DiscountCongfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {


            builder.Property(d => d.CompanyTaxId).IsRequired();
            builder.HasOne(d => d.Company)
                   .WithMany(d => d.Discounts)
                   .HasForeignKey(d => d.CompanyTaxId)
                   .HasPrincipalKey(c => c.TaxId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
