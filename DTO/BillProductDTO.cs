namespace BadmintonCourtManagement.DTO
{
    public class BillProductDTO
    {
        private string billProductId = "";
        private string employeeId = "";
        private string customerId = "";
        private double totalPrice = 0;
        private DateTime dateCreated = DateTime.Now;
        public enum Option { Paid, Unpaid };
        private Option status = Option.Unpaid;

        public string BillProductId { get => billProductId; set => billProductId = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string CustomerId { get => customerId; set => customerId = value; }
        public double TotalPrice
        {
            get => totalPrice;
            set
            {
                if (value >= 0)
                    totalPrice = value;
                else
                    throw new ArgumentException("Total price must be non-negative.");
            }
        }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public Option Status { get => status; set => status = value; }

        public BillProductDTO() { }
        public BillProductDTO(string billProductId, string employeeId, string customerId, double totalPrice, DateTime dateCreated, Option status)
        {
            BillProductId = billProductId;
            EmployeeId = employeeId;
            CustomerId = customerId;
            TotalPrice = totalPrice;
            DateCreated = dateCreated;
            Status = status;
        }
    }
}