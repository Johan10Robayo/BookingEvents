namespace Booking_Events_API.Domain.Entities
{
    public class Person
    {
        public long DniNumber { get; set; }
        public string IdentificationType { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string SurName { get; set; } = string.Empty;
        public int Age { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateOnly BirthDate { get; set; }
        public string Country { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public HashSet<Company> Companies { get; set; } = new HashSet<Company>();
        public HashSet<Person> Persons { get; set; } = new HashSet<Person>();
    }
}
