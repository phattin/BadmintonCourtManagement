namespace BadmintonCourtManagement.DTO
{
    public class EmployeeDTO
    {
        private string employeeId = "";
        private string employeeName = "";
        private string employeePhone = "";
        private string employeeAddress = "";
        private string username = "";
        private string roleId = "";

        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeePhone
        {
            get => employeePhone;
            set
            {
                if (value.Length == 10 && System.Text.RegularExpressions.Regex.IsMatch(value, @"^0(9|8|6|5|7|3)\d{8}$"))
                {
                    employeePhone = value;
                }
                else
                {
                    throw new Exception("Số điện thoại không hợp lệ!");
                }
            }
        }
        public string Address { get => employeeAddress; set => employeeAddress = value; }
        public string Username { get => username; set => username = value; }
        public string RoleId { get => roleId; set => roleId = value; }

        public EmployeeDTO()
        {
            this.EmployeeId = "";
            this.EmployeeName = "";
            this.EmployeePhone = "";
            this.Address = "";
            this.Username = "";
            this.RoleId = "";
        }

        public EmployeeDTO(string employeeId, string employeeName, string employeePhone, string employeeAddress, string username, string roleId)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.EmployeePhone = employeePhone;
            this.Address = employeeAddress;
            this.Username = username;
            this.RoleId = roleId;
        }
    }
}