namespace BadmintonCourtManagement.DTO
{
    class TypeProductDTO
    {
        private string id = "";
        private string name = "";
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public TypeProductDTO() { }
        public TypeProductDTO(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}