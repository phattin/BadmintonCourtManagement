namespace BadmintonCourtManagement.DTO
{
    public class BillBookingDTO
    {
        // Properties tương ứng với database
        public string BillBookingId { get; set; } = "";
        public string EmployeeId { get; set; } = "";
        public string CustomerId { get; set; } = "";
        public string BookingId { get; set; } = "";
        public double TotalPrice { get; set; } = 0;
        public double PrePayment { get; set; } = 0;  // Đổi từ PrePaid sang PrePayment

        // Constructors
        public BillBookingDTO() { }

        public BillBookingDTO(string billBookingId, string employeeId, string customerId,
                              string bookingId, double totalPrice, double prePayment)
        {
            BillBookingId = billBookingId;
            EmployeeId = employeeId;
            CustomerId = customerId;
            BookingId = bookingId;
            TotalPrice = totalPrice;
            PrePayment = prePayment;
        }
    }
}
