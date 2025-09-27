namespace BadmintonCourtManagement.DTO
{
    public class RoleDTO
    {
        private string roleId = "";
        private string roleName = "";
        public string RoleId { get => roleId; set => roleId = value; }
        public string RoleName { get => roleName; set => roleName = value; }

        public RoleDTO(string roleId, string roleName)
        {
            this.RoleId = roleId;
            this.RoleName = roleName;
        }

        public RoleDTO()
        {
            this.RoleId = "";
            this.RoleName = "";
        }
    }
}