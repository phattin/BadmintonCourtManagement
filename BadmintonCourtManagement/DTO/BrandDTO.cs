namespace BadmintonCourtManagement.DTO
{ 
    public class BrandDTO
    {
        private string brandId = "";
        private string brandName = "";
        public string BrandId { get => brandId; set => brandId = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public BrandDTO() { }
        public BrandDTO(string brandId, string brandName)
        {
            this.BrandId = brandId;
            this.BrandName = brandName;
        }
    }
}