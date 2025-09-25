namespace BadmintonCourtManagement.DTO
{
    public class ProductDTO
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string Producing { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public string BrandId { get; set; } = string.Empty;
        public string TypeId { get; set; } = string.Empty;
        public int IsDeleted { get; set; } = 0; 

        public ProductDTO() { }

        public ProductDTO(string productId, string productName, string producing, int quantity, string brandId, string typeId, int isDeleted = 0)
        {
            ProductId = productId;
            ProductName = productName;
            Producing = producing;
            Quantity = quantity;
            BrandId = brandId;
            TypeId = typeId;
            IsDeleted = isDeleted;
        }

        public override string ToString()
        {
            return $"[{ProductId}] {ProductName} - SL: {Quantity}, Brand: {BrandId}, Type: {TypeId}, Deleted: {IsDeleted}";
        }
    }
}
