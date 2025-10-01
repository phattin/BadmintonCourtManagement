namespace BadmintonCourtManagement.DTO
{
    public class BillProductDetailDTO
    {
        private string billProductId = "";
        private string productId = "";
        private int quantity = 0;
        private double price = 0;
        private double totalPrice = 0;

        public string BillProductId { get => billProductId; set => billProductId = value; }
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
                else
                {
                    throw new ArgumentException("Quantity value should be >= 0");
                }
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
                else
                {
                    throw new ArgumentException("Price value should be >= 0");
                }
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

        public BillProductDetailDTO() { }
        public BillProductDetailDTO(string billProductId, string productId, int quantity, double price, double totalPrice)
        {
            BillProductId = billProductId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            TotalPrice = totalPrice;
        }
    }
}