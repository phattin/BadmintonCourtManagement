namespace BadmintonCourtManagement.DTO
{
    class PermissionDTO
    {
        private string id = "";
        private string name = "";

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public PermissionDTO() { }

        public PermissionDTO(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}