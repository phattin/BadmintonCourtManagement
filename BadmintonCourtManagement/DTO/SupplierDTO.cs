namespace BadmintonCourtManagement.DTO
{
    public class SupplierDTO
    {
        private string supplierId = "";
        private string supplierName = "";
        private string supplierAddress = "";
        private string supplierEmail = "";
        private int isDeleted = 0;

        public string SupplierId { get => supplierId; set => supplierId = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string SupplierAddress { get => supplierAddress; set => supplierAddress = value; }
        public string SupplierEmail { get => supplierEmail; set => supplierEmail = value; }
        public int IsDeleted { get => isDeleted; set => isDeleted = value; }

        public SupplierDTO() { }
        public SupplierDTO(string supplierId, string supplierName, string supplierAddress, string supplierEmail, int isDeleted)
        {
            this.SupplierId = supplierId;
            this.SupplierName = supplierName;
            this.SupplierAddress = supplierAddress;
            this.SupplierEmail = supplierEmail;
            this.IsDeleted = isDeleted;
        }
    }
}