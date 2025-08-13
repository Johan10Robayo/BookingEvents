using Booking_Events_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Events_API.Infrastructure.Configurations
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasOne(s => s.Venue)
            .WithMany()
            .HasForeignKey(p => p.VenueId)
            .OnDelete(DeleteBehavior.NoAction);
            
        }

    }
}
