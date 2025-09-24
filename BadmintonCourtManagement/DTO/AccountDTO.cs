using System;

namespace BadmintonCourtManagement.DTO
{
    public class AccountDTO
    {
        private string username;
        private string password;
        private string permissionId;
        private int isDeleted;

        public AccountDTO()
        {
            username = "";
            password = "";
            permissionId = "";
            isDeleted = 0;
        }

        public AccountDTO(string username, string password, string permissionId, int isDeleted)
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

        public int IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

    }
}
