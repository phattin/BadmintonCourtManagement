namespace BadmintonCourtManagement.DTO
{
    public class BillBookingDTO
    {
        // Thông tin hóa đơn chính
        public string BillBookingId { get; set; } = string.Empty;
        public string BookingId { get; set; } = string.Empty;
        public string EmployeeId { get; set; } = string.Empty;
        public string CustomerId { get; set; } = string.Empty;
        public double TotalPrice { get; set; } = 0;
        public double PrePayment { get; set; } = 0;

        // Tính toán tự động - rất hay!
        public double RemainingAmount => TotalPrice - PrePayment;

        // Thông tin hiển thị (JOIN từ các bảng khác)
        public string EmployeeName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string CourtId { get; set; } = string.Empty;
        public string CourtName { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Dùng enum thay vì string sẽ an toàn và đẹp hơn
        public BookingStatus Status { get; set; } = BookingStatus.successful;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        // Enum đúng với DB
        public enum BookingStatus
        {
            successful,
            played
        }

        // Constructor mặc định
        public BillBookingDTO() { }

        // Constructor cơ bản (khi tạo mới hóa đơn)
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

        // Constructor đầy đủ nhất - dùng để hiển thị danh sách hóa đơn đặt sân
        public BillBookingDTO(string billBookingId, string bookingId,
            string employeeId, string employeeName,
            string customerId, string customerName, string phone,
            string courtId, string courtName,
            DateTime startTime, DateTime endTime, BookingStatus status,
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
            Status = status;
            TotalPrice = totalPrice;
            PrePayment = prePayment;
            DateCreated = dateCreated;
        }
    }
}