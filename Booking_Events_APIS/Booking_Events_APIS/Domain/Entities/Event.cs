using System;

namespace Booking_Events_APIS.Domain.Entities
{
    public class Event
    {
        public long Id { get; set; }
        public long VenueId { get; set; }
        public Venue? Venue { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EventType { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Photos { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
