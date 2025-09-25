namespace BadmintonCourtManagement.DTO
{
    class BillImportProductDetailDTO
    {
        private string importBillId = "";
        private string productId = "";
        private int quantity = 0;
        private int price = 0;
        private int totalPrice = 0;
        private string status = "";

        public string ImportBillId { get => importBillId; set => importBillId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Status { get => status; set => status = value; }

        public BillImportProductDetailDTO() { }

        public BillImportProductDetailDTO(string importBillId, string productId, int quantity, int price, int totalPrice, string status)
        {
            this.ImportBillId = importBillId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Price = price;
            this.TotalPrice = totalPrice;
            this.Status = status;
        }
    }
}
