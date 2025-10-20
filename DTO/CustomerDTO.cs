namespace BadmintonCourtManagement.DTO
{
    public class CustomerDTO
    {
        private string customerId = "";
        private string customerName = "";
        private string customerPhone = "";
        private int isDeleted = 0;

        public string CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerPhone
        {
            get => customerPhone;
            set => customerPhone = value;
        }
        public int IsDeleted { get => isDeleted; set => isDeleted = value; }

        public CustomerDTO()
        {
            this.CustomerId = "";
            this.CustomerName = "";
            this.CustomerPhone = "";
            this.IsDeleted = 0;
        }

        public CustomerDTO(string customerId, string customerName, string customerPhone, int isDeleted)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.CustomerPhone = customerPhone;
            this.IsDeleted = isDeleted;
        }
    }
}