namespace BadmintonCourtManagement.DTO
{
    public class PriceBookingDetailDTO
    {
        private string priceRuleId = "";
        private string billBookingId = "";
        private double price = 0;

        public string PriceRuleId { get => priceRuleId; set => priceRuleId = value; }
        public string BillBookingId { get => billBookingId; set => billBookingId = value; }
        public double Price { get => price; set => price = value; }

        public PriceBookingDetailDTO() { }
        public PriceBookingDetailDTO(string id, string priceRuleId, string bookingDetailId, double price)
        {
            this.PriceRuleId = priceRuleId;
            this.BillBookingId = billBookingId;
            this.Price = price;
        }
    }
}