namespace BadmintonCourtManagement.DTO
{
    class SupplierDTO
    {
        private string id = "";
        private string name = "";
        private string address = "";
        private string email = "";
        private bool isDeleted = false;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }

        public SupplierDTO() { }
        public SupplierDTO(string id, string name, string address, string email, bool isDeleted)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.IsDeleted = isDeleted;
        }
    }
}