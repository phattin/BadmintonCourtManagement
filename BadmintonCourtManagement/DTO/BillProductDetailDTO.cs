namespace BadmintonCourtManagement.DTO
{
    class BillProductDetailDTO
    {
        private string billProductId = "";
        private string productId = "";
        private int quantity = 0;
        private int price = 0;
        private int totalPrice = 0;

        public string BillProductId { get => billProductId; set => billProductId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }

        public BillProductDetailDTO() { }

        public BillProductDetailDTO(string billProductId, string productId, int quantity, int price, int totalPrice)
        {
            this.BillProductId = billProductId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
    }
}
