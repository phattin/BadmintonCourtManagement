namespace BadmintonCourtManagement.DTO
{ 
    public class ProductDTO
    {
        private string productId = "";
        private string productName = "";
        private string supplierId = "";
        private string productImg = "DefaultProductImage.jpg";
        private int quantity = 0;
        private string brandId = "";
        private string typeId = "";
        private int isDeleted = 0;

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string SupplierId { get => supplierId; set => supplierId = value; }
        public string ProductImg { get => productImg; set => productImg = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string BrandId { get => brandId; set => brandId = value; }
        public string TypeId { get => typeId; set => typeId = value; }
        public int IsDeleted { get => isDeleted; set => isDeleted = value; }

        public ProductDTO() { }
        public ProductDTO(string productId, string productName, string supplierId, string productImg, int quantity, string brandId, string typeId, int isDeleted)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.SupplierId = supplierId;
            this.ProductImg = productImg;
            this.Quantity = quantity;
            this.BrandId = brandId;
            this.TypeId = typeId;
            this.IsDeleted = isDeleted;
        }
    }
}