namespace Booking_Events_API.Domain.Entities
{
    public class Venue
    {
        public long Id { get; set; }
        public string CompanyId { get; set; } = string.Empty;
        public Company? Company { get; set; }
        public string Name { get; set; } = string.Empty;
        public string VenueType { get; set; } = string.Empty;
        public int AudienceCapacity { get; set; }
        public string Country { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool ParkingAvailability { get; set; }
        public string VenueDescription { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Photos { get; set; } = string.Empty;
        public int StateWidth { get; set; }
        public int StateHeight { get; set; }
        public int VenueWidth { get; set; }
        public int VenueHeight { get; set; }
        public HashSet<Event> Events { get; set; } = new HashSet<Event>();
        public HashSet<Section> Sections { get; set; } = new HashSet<Section>();


    }
}
