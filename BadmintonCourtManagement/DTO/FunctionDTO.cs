namespace BadmintonCourtManagement.DTO
{
    class FunctionDTO
    {
        private string id = "";
        private string name = "";

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public FunctionDTO()
        {
            id = "";
            name = "";
        }

        public FunctionDTO(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}