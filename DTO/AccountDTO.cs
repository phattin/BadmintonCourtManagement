using System;

namespace BadmintonCourtManagement.DTO
{
    public class AccountDTO
    {
        private string username;
        private string password;
        private string permissionId;
        private int isDeleted;
        private string employeeId;

        public AccountDTO()
        {
            username = "";
            password = "";
            permissionId = "";
            employeeId = "";
            isDeleted = 0;
        }

        public AccountDTO(string username, string password, string permissionId, int isDeleted, string employeeId)
        {
            this.username = username;
            this.password = password;
            this.permissionId = permissionId;
            this.isDeleted = isDeleted;
            this.employeeId = employeeId;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string PermissionId
        {
            get { return permissionId; }
            set { permissionId = value; }
        }

        public int IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

    }
}
