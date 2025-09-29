namespace BadmintonCourtManagement.DTO
{ 
    public class BookingDTO
    {
        private string bookingId = "";
        private string courtId = "";
        private DateTime startTime;
        private DateTime endTime;
        private int status = 0;

        public string BookingId { get => bookingId; set => bookingId = value; }
        public string CourtId { get => courtId; set => courtId = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public int Status { get => status; set => status = value; }

        public BookingDTO()
        {
            this.BookingId = "";
            this.CourtId = "";
            this.Status = 0;
            this.StartTime = DateTime.Now;
            this.EndTime = DateTime.Now;
        }

        public BookingDTO(string bookingId, string courtId, int status, DateTime startTime, DateTime endTime)
        {
            this.BookingId = bookingId;
            this.CourtId = courtId;
            this.Status = status;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
    }
}