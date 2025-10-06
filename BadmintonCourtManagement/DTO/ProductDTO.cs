namespace BadmintonCourtManagement.DTO
{ 
    public class ProductDTO
    {
        private string productId = "";
        private string productName = "";
        private string producing = "";
        private int quantity = 0;
        private string brandId = "";
        private string typeId = "";
        private int iDeleted = 0;

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Producing { get => producing; set => producing = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string BrandId { get => brandId; set => brandId = value; }
        public string TypeId { get => typeId; set => typeId = value; }
        public int IDeleted { get => iDeleted; set => iDeleted = value; }

        public ProductDTO() { }
        public ProductDTO(string productId, string productName, string producing, int quantity, string brandId, string typeId, int iDeleted)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Producing = producing;
            this.Quantity = quantity;
            this.BrandId = brandId;
            this.TypeId = typeId;
            this.IDeleted = iDeleted;
        }
    }
}