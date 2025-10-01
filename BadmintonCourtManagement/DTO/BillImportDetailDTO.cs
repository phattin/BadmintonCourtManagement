namespace BadmintonCourtManagement.DTO
{
    public class BillImportDetailDTO
    {
        private string importBillId = "";
        private string productId = "";
        private int quantity = 0;
        private double price = 0;
        private double totalPrice = 0;
        public enum Option { Paid, Unpaid };
        private Option status;

        public string ImportBillId { get => importBillId; set => importBillId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public int Quantity
        {
            get => quantity;
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
<<<<<<< HEAD
=======
                else
                {
                    throw new ArgumentException("Quantity value should be >= 0");
                }
>>>>>>> main
            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
<<<<<<< HEAD
=======
                else
                {
                    throw new ArgumentException("Price value should be >= 0");
                }
>>>>>>> main
            }
        }
        public double TotalPrice
        {
            get => totalPrice;
            set
            {
                if (quantity >= 0 && price >= 0)
                {
                    totalPrice = price * quantity;
                }
            }
        }
        public Option Status { get => status; set => status = value; }

        public BillImportDetailDTO() { }
        public BillImportDetailDTO(string importBillId, string productId, int quantity, double price, double totalPrice, Option status)
        {
            ImportBillId = importBillId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            TotalPrice = totalPrice;
            Status = status;
        }
    }
}