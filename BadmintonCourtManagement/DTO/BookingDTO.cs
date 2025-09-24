namespace BadmintonCourtManagement.DTO
{ 
    class BookingDTO
    {
        private string id = "";
        private string courtId = "";
        private DateTime startTime;
        private DateTime endTime;
        private bool status;

        public string Id { get => id; set => id = value; }
        public string CourtId { get => courtId; set => courtId = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public bool Status { get => status; set => status = value; }

        public BookingDTO()
        {
            this.Id = "";
            this.CourtId = "";
            this.Status = false;
            this.StartTime = DateTime.Now;
            this.EndTime = DateTime.Now;
        }

        public BookingDTO(string id, string courtId, bool status, DateTime startTime, DateTime endTime)
        {
            this.Id = id;
            this.CourtId = courtId;
            this.Status = status;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
    }
}