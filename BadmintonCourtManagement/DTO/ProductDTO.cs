namespace BadmintonCourtManagement.DTO
{
    class ProductDTO
    {
        private string productId = "";
        private string productName = "";
        private string producing = "";
        private int quantity = 0;
        private string brandId = "";
        private string typeId = "";
        private int isDeleted = 0; // 0 = chưa xóa, 1 = đã xóa

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Producing { get => producing; set => producing = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string BrandId { get => brandId; set => brandId = value; }
        public string TypeId { get => typeId; set => typeId = value; }
        public int IsDeleted { get => isDeleted; set => isDeleted = value; }

        public ProductDTO() { }

        public ProductDTO(string productId, string productName, string producing, int quantity, string brandId, string typeId, int isDeleted)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Producing = producing;
            this.Quantity = quantity;
            this.BrandId = brandId;
            this.TypeId = typeId;
            this.IsDeleted = isDeleted;
        }
    }
}
