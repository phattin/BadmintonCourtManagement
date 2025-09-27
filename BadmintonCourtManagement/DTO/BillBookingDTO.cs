namespace BadmintonCourtManagement.DTO
{
    public class BillBookingDTO
    {
        private string billBookingId = "";
        private string bookingId = "";
        private double totalPrice;
        private string employeeId = "";
        private string customerId = "";
        private DateTime dateCreated = DateTime.Now;
        private double prePaid = 0;

        public string BillBookingId { get => billBookingId; set => billBookingId = value; }
        public string BookingId { get => bookingId; set => bookingId = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string CustomerId { get => customerId; set => customerId = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public double PrePaid { get => prePaid; set => prePaid = value; }

        public BillBookingDTO() { }
        public BillBookingDTO(string billBookingId, string bookingId, double totalPrice, string employeeId, string customerId, DateTime dateCreated, double prePaid)
        {
            this.BillBookingId = billBookingId;
            this.BookingId = bookingId;
            this.TotalPrice = totalPrice;
            this.EmployeeId = employeeId;
            this.CustomerId = customerId;
            this.DateCreated = dateCreated;
            this.PrePaid = prePaid;
        }
    }
}