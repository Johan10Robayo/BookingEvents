using Booking_Events_APIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Events_APIS.Infrastruture.Configuration
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            //builder.HasOne(p => p.Section)
            //.WithMany()
            //.HasForeignKey(p => p.SectionId)
            //.OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(p => p.Event)
            //.WithMany()
            //.HasForeignKey(p => p.EventId)
            //.OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(p => p.User)
            //.WithMany(u => u.Purchases)
            //.HasForeignKey(p => p.UserId)
            //.OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(p => p.Discount)
            //.WithMany()
            //.HasForeignKey(p => p.DiscountId)
            //.OnDelete(DeleteBehavior.NoAction);

        }
    }
}
