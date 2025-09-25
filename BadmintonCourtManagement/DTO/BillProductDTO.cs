namespace BadmintonCourtManagement.DTO
{
    class BillProductDTO
    {
        private string billProductId = "";
        private string employeeId = "";
        private string customerId = "";
        private int totalPrice = 0;
        private string status = "";

        public string BillProductId { get => billProductId; set => billProductId = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string CustomerId { get => customerId; set => customerId = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Status { get => status; set => status = value; }

        public BillProductDTO() { }

        public BillProductDTO(string billProductId, string employeeId, string customerId, int totalPrice, string status)
        {
            this.BillProductId = billProductId;
            this.EmployeeId = employeeId;
            this.CustomerId = customerId;
            this.TotalPrice = totalPrice;
            this.Status = status;
        }
    }
}
