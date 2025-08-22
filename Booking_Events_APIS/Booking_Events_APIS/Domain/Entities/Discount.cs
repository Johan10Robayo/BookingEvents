namespace Booking_Events_APIS.Domain.Entities
{
    public class Discount
    {
        public long Id { get; set; }
        public string CompanyTaxId { get; set; } = string.Empty;
        public Company? Company { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public decimal MinPurchaseAmount { get; set; }
        public bool IsActive { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public string DiscountType { get; set; } = string.Empty;
    }
}
