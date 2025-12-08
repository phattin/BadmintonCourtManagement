namespace BadmintonCourtManagement.DTO
{
    public class BillBookingDTO
    {
        // Thông tin hóa đơn
        public string BillBookingId { get; set; } = "";
        public string BookingId { get; set; } = "";
        public string EmployeeId { get; set; } = "";
        public string CustomerId { get; set; } = "";
        public double TotalPrice { get; set; } = 0;
        public double PrePayment { get; set; } = 0;         // Tiền đặt cọc / trả trước
        public double RemainingAmount => TotalPrice - PrePayment; // Tiền còn lại phải thu

        // Thông tin bổ sung để hiển thị (JOIN từ các bảng khác)
        public string EmployeeName { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string Phone { get; set; } = "";
        public string CourtId { get; set; } = "";
        public string CourtName { get; set; } = "";
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string BookingStatus { get; set; } = "successful"; // successful / played
        public DateTime DateCreated { get; set; } = DateTime.Now;

        // Constructor mặc định
        public BillBookingDTO() { }

        // Constructor đầy đủ (khi chỉ cần dữ liệu chính)
        public BillBookingDTO(string billBookingId, string bookingId, string employeeId, 
            string customerId, double totalPrice, double prePayment)
        {
            BillBookingId = billBookingId;
            BookingId = bookingId;
            EmployeeId = employeeId;
            CustomerId = customerId;
            TotalPrice = totalPrice;
            PrePayment = prePayment;
        }

        // Constructor dùng khi lấy dữ liệu chi tiết để hiển thị trên grid/card
        public BillBookingDTO(string billBookingId, string bookingId, string employeeId, string employeeName,
            string customerId, string customerName, string phone,
            string courtId, string courtName,
            DateTime startTime, DateTime endTime, string bookingStatus,
            double totalPrice, double prePayment, DateTime dateCreated)
        {
            BillBookingId = billBookingId;
            BookingId = bookingId;
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            CustomerId = customerId;
            CustomerName = customerName;
            Phone = phone;
            CourtId = courtId;
            CourtName = courtName;
            StartTime = startTime;
            EndTime = endTime;
            BookingStatus = bookingStatus;
            TotalPrice = totalPrice;
            PrePayment = prePayment;
            DateCreated = dateCreated;
        }
    }
}