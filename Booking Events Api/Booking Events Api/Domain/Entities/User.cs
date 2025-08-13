namespace Booking_Events_API.Domain.Entities
{
    public class User
    {
        public string UserName { get; set; } = string.Empty;
        public long PersonId { get; set; }
        public Person? Person { get; set; }
        public string Password { get; set; } = string.Empty;
        public DateOnly CreationDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateOnly ExpirationDate { get; set; }
        public DateOnly LastLoginDate { get; set; }
        public DateOnly PasswordExpirationDate { get; set; }
        public DateOnly LastChangeDate { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string ProfilePhoto { get; set; } = string.Empty;
        public List<RoleUser> RoleUsers { get; set; } = new List<RoleUser>();
        public List<Purchase> Purchases { get; set; } = new List<Purchase>();

    }
}
