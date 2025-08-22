namespace Booking_Events_APIS.Domain.Entities
{
    public class RoleUser
    {
        public long RoleId { get; set; }
        public Role? Role { get; set; }
        public long UserId { get; set; }
        public User? User { get; set; }
        public DateOnly AssignmentDate { get; set; }
    }
}
