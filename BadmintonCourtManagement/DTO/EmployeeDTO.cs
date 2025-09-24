namespace BadmintonCourtManagement.DTO
{
    class EmployeeDTO
    {
        private string id = "";
        private string name = "";
        private string phone = "";
        private string address = "";
        private string username = "";
        private string roleId = "";

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
                    throw new Exception("Số điện thoại không hợp lệ!");
                }
            }
        }
        public string Address { get => address; set => address = value; }
        public string Username { get => username; set => username = value; }
        public string RoleId { get => roleId; set => roleId = value; }

        public EmployeeDTO()
        {
            this.Id = "";
            this.Name = "";
            this.Phone = "";
            this.Address = "";
            this.Username = "";
            this.RoleId = "";
        }

        public EmployeeDTO(string id, string name, string phone, string address, string username, string roleId)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.Username = username;
            this.RoleId = roleId;
        }
    }
}