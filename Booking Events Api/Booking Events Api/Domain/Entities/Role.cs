namespace Booking_Events_API.Domain.Entities
{
    public class Role
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; }
        public string PriorityLevel { get; set; } = string.Empty;
        public List<RoleUser> RoleUsers { get; set; } = new List<RoleUser>();
    }
}
