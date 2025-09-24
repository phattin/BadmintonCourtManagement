namespace BadmintonCourtManagement.DTO
{
    class CustomerDTO
    {
        private string id = "";
        private string name = "";
        private string phone = "";
        private bool isDeleted = false;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone
        {
            get => phone;
            set
            {
                if (value.Length == 10 && System.Text.RegularExpressions.Regex.IsMatch(value, @"^0(9|8|6|5|7|3)\d{8}$"))
                {
                    phone = value;
                }
                else
                {
                    throw new Exception("Số điện thoại không hợp lệ");
                }
            }
        }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }

        public CustomerDTO() { }

        public CustomerDTO(string id, string name, string phone, bool isDeleted)
        {
            this.id = id;
            this.name = name;
            Phone = phone;
            this.isDeleted = isDeleted;
        }
    }
}