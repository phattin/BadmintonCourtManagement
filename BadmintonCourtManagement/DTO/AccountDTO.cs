using System;

namespace BadmintonCourtManagement.DTO
{
    public class AccountDTO
    {
        private string username;
        private string password;
        private string permissionId;
        private bool isDeleted;

        public AccountDTO()
        {
            username = "";
            password = "";
            permissionId = "";
            isDeleted = false;
        }

        public AccountDTO(string username, string password, string permissionId, bool isDeleted)
        {
            this.username = username;
            this.password = password;
            this.permissionId = permissionId;
            this.isDeleted = isDeleted;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
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

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

    }
}
