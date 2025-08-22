using System;

namespace Booking_Events_APIS.Domain.Entities
{
    public class Section
    {
        public long Id { get; set; }
        public long VenueId { get; set; }
        public Venue? Venue { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ChairList { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
