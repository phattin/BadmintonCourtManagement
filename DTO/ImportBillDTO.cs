namespace BadmintonCourtManagement.DTO
{
    public class ImportBillDTO
    {
        private string importBillId = "";
        private string supplierId = "";
        private string employeeId = "";
        private DateTime dateCreated = DateTime.Now;
        private double totalPrice = 0;
        public enum Option { pending, delivered, cancelled, paid, unpaid }
        private Option status = Option.unpaid;

        public string ImportBillId { get => importBillId; set => importBillId = value; }
        public string SupplierId { get => supplierId; set => supplierId = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public Option Status { get => status; set => status = value; }

        public ImportBillDTO() { }
        public ImportBillDTO(string importBillId, string supplierId, string employeeId, DateTime dateCreated, double totalPrice, Option status)
        {
            this.ImportBillId = importBillId;
            this.SupplierId = supplierId;
            this.EmployeeId = employeeId;
            this.DateCreated = dateCreated;
            this.TotalPrice = totalPrice;
            this.Status = status;
        }
	public ImportBillDTO(string importBillId, string supplierId, string employeeId, double totalPrice, Option status) {
            this.ImportBillId = importBillId;
            this.SupplierId = supplierId;
            this.EmployeeId = employeeId;
            this.TotalPrice = totalPrice;
            this.Status = status;
	}
    }
}
