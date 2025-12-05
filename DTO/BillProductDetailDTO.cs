namespace BadmintonCourtManagement.DTO
{
    public class BillProductDetailDTO
    {
        private string billProductDetailId = "";
        private string billProductId = "";
        private string productId = "";
        private int quantity = 0;
        private double price = 0;
        private double totalPrice = 0;

        public string BillProductDetailId { get => billProductDetailId; set => billProductDetailId = value; }
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
        public BillProductDetailDTO(string billProductDetailId, string billProductId, string productId, int quantity, double price, double totalPrice)
        {
            BillProductDetailId = billProductDetailId;
            BillProductId = billProductId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            TotalPrice = totalPrice;
        }
    }
}