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
            set
            {
                if (value.Length == 10 && System.Text.RegularExpressions.Regex.IsMatch(value, @"^0(9|8|6|5|7|3)\d{8}$"))
                {
                    customerPhone = value;
                }
                else
                {
                    throw new Exception("Số điện thoại không hợp lệ");
                }
            }
        }
        public int IsDeleted { get => isDeleted; set => isDeleted = value; }

        public CustomerDTO() { }

        public CustomerDTO(string customerId, string customerName, string customerPhone, int isDeleted)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.CustomerPhone = customerPhone;
            this.IsDeleted = isDeleted;
        }
    }
}