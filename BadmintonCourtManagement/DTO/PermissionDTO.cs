namespace BadmintonCourtManagement.DTO
{
    public class PermissionDTO
    {
        private string permissionId = "";
        private string permissionName = "";

        public string PermissionId { get => permissionId; set => permissionId = value; }
        public string PermissionName { get => permissionName; set => permissionName = value; }

        public PermissionDTO() { }

        public PermissionDTO(string permissionId, string permissionName)
        {
            this.PermissionId = permissionId;
            this.PermissionName = permissionName;
        }
    }
}