namespace BadmintonCourtManagement.DTO
{
    class RoleDTO
    {
        private string id;
        private string name;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public RoleDTO(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public RoleDTO()
        {
            this.Id = "";
            this.Name = "";
        }
    }
}