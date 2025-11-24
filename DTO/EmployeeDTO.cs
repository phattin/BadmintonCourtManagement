namespace BadmintonCourtManagement.DTO
{
    public class EmployeeDTO
    {
        private string employeeId = "";
        private string employeeName = "";
        private string employeePhone = "";
        private string employeeAddress = "";
        private string roleId = "";

        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeePhone { get => employeePhone; set => employeePhone = value; }
        public string Address { get => employeeAddress; set => employeeAddress = value; }
        public string RoleId { get => roleId; set => roleId = value; }

        public EmployeeDTO()                                
        {
            this.EmployeeId = "";
            this.EmployeeName = "";
            this.EmployeePhone = "";
            this.Address = "";
            this.RoleId = "";
        }

        public EmployeeDTO(string employeeId, string employeeName, string employeePhone, string employeeAddress, string roleId)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.EmployeePhone = employeePhone;
            this.Address = employeeAddress;
            this.RoleId = roleId;
        }
    }
}