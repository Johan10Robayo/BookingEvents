using Booking_Events_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Events_API.Infrastructure.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasOne(e => e.Venue)
           .WithMany()
           .HasForeignKey(e => e.VenueId)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
