namespace BadmintonCourtManagement.DTO
{
    class CourtDTO
    {
        private string id = "";
        private string name = "";
        public enum Option { Active, UnderMaintenance };
        private Option status = Option.Active;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Option Status { get => status; set => status = value; }

        public CourtDTO()
        {
            this.Id = "";
            this.Name = "";
            this.Status = Option.Active;
        }

        public CourtDTO(string id, string name, Option status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
    }
}