namespace BadmintonCourtManagement.DTO
{
    public class PriceRuleDTO
    {
        private string priceRuleId = "";
        private double price = 0;
        private TimeOnly startTime = TimeOnly.MinValue;
        private TimeOnly endTime = TimeOnly.MinValue;
        private DateOnly? startDate = null;
        private DateOnly? endDate = null;
        private string endType = "";
        private string description = "";
        private int isActive = 0;

        public string PriceRuleId { get => priceRuleId; set => priceRuleId = value; }
        public double Price { get => price; set => price = value; }
        public TimeOnly StartTime { get => startTime; set => startTime = value; }
        public TimeOnly EndTime { get => endTime; set => endTime = value; }
        public DateOnly? StartDate { get => startDate; set => startDate = value; }
        public DateOnly? EndDate { get => endDate; set => endDate = value; }
        public string Description { get => description; set => description = value; }
        public int IsActive { get => isActive; set => isActive = value; }
        public string EndType { get => endType; set => endType = value; }

        public PriceRuleDTO() { }
        public PriceRuleDTO(string priceRuleId, double price, TimeOnly startTime, TimeOnly endTime, DateOnly? startDate, DateOnly? endDate,string endType, string description, int isActive)
        {
            this.PriceRuleId = priceRuleId;
            this.Price = price;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.EndType = endType;
            this.Description = description;
            this.IsActive = isActive;
        }
        public PriceRuleDTO(double price, TimeOnly startTime, TimeOnly endTime, DateOnly? startDate, DateOnly? endDate, string endType, string description, int isActive)
        {
            this.Price = price;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.EndType = endType;
            this.Description = description;
            this.IsActive = isActive;
        }
    }
}