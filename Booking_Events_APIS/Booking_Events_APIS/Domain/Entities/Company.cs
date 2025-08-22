using System;

namespace Booking_Events_APIS.Domain.Entities
{
    public class Company
    {
        public string TaxId { get; set; } = string.Empty;
        public long LegalRepresentative { get; set; }
        public Person? Person { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public DateOnly DateIncorporation { get; set; }
        public string Country { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public long Phone { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CurrentStatus { get; set; } = string.Empty;
        public string CompanyState { get; set; } = string.Empty;
        public string CompanyType { get; set; } = string.Empty;
        public int EmployeesNumber { get; set; }
        public DateOnly LastUpdateDate { get; set; }
        public string OperatingArea { get; set; } = string.Empty;
        public string CompanyCategory { get; set; } = string.Empty;
        public string BusinessRegistrationNumber { get; set; } = string.Empty;
        public string WebSite { get; set; } = string.Empty;
        public HashSet<Venue> Venues { get; set; } = new HashSet<Venue>();
        public HashSet<Discount> Discounts { get; set; } = new HashSet<Discount>();
    }
}
