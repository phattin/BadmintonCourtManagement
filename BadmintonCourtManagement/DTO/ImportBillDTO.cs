namespace BadmintonCourtManagement.DTO
{
    class ImportBillDTO
    {
        private string id = "";
        private string supplierId = "";
        private string employeeId = "";
        private DateTime dateCreated = DateTime.Now;
        private double totalPrice = 0;
        public enum Option { Pending, Delivered, Cancelled, Paid, Unpaid }
        private Option status = Option.Unpaid;

        public string Id { get => id; set => id = value; }
        public string SupplierId { get => supplierId; set => supplierId = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public Option Status { get => status; set => status = value; }

        public ImportBillDTO() { }
        public ImportBillDTO(string id, string supplierId, string employeeId, DateTime dateCreated, double totalPrice, Option status)
        {
            this.Id = id;
            this.SupplierId = supplierId;
            this.EmployeeId = employeeId;
            this.DateCreated = dateCreated;
            this.TotalPrice = totalPrice;
            this.Status = status;
        }
    }
}