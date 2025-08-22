using static System.Collections.Specialized.BitVector32;

namespace Booking_Events_APIS.Domain.Entities
{
    public class Purchase
    {
        public long Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public User? User { get; set; }
        public long DiscountId { get; set; }
        public Discount? Discount { get; set; }
        public long EventId { get; set; }
        public Event? Event { get; set; }
        public long SectionId { get; set; }
        public Section? Section { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public decimal SubTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public int NumberOfTickets { get; set; }
        public string ChairList { get; set; } = string.Empty;
    }
}
