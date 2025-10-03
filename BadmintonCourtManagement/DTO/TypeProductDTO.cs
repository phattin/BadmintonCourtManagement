namespace BadmintonCourtManagement.DTO
{
    public class TypeProductDTO
    {
        private string typeProductId = "";
        private string typeProductName = "";
        public string TypeProductId { get => typeProductId; set => typeProductId = value; }
        public string TypeProductName { get => typeProductName; set => typeProductName = value; }
        public TypeProductDTO() { }
        public TypeProductDTO(string typeProductId, string typeProductName)
        {
            this.TypeProductId = typeProductId;
            this.TypeProductName = typeProductName;
        }
    }
}