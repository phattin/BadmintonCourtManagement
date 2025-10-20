namespace BadmintonCourtManagement.DTO
{
    public class CourtDTO
    {
        private string courtId = "";
        private string courtName = "";
        public enum Option { active, maintenance };
        private Option status = Option.active;

        public string CourtId { get => courtId; set => courtId = value; }
        public string CourtName { get => courtName; set => courtName = value; }
        public Option Status { get => status; set => status = value; }

        public CourtDTO()
        {
            this.CourtId = "";
            this.CourtName = "";
            this.Status = Option.active;
        }

        public CourtDTO(string courtId, string courtName, Option status)
        {
            this.CourtId = courtId;
            this.CourtName = courtName;
            this.Status = status;
        }
    }
}