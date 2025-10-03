namespace BadmintonCourtManagement.DTO
{ 
    public class BookingDTO
    {
        private string bookingId = "";
        private string courtId = "";
        private DateTime startTime = DateTime.Now;
        private DateTime endTime = DateTime.Now;
        public enum Option { successful, played };
        private Option status = Option.played;

        public string BookingId { get => bookingId; set => bookingId = value; }
        public string CourtId { get => courtId; set => courtId = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public Option Status { get => status; set => status = value; }

        public BookingDTO(){}
        public BookingDTO(string bookingId, string courtId, Option status, DateTime startTime, DateTime endTime)
        {
            this.BookingId = bookingId;
            this.CourtId = courtId;
            this.Status = status;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
    }
}