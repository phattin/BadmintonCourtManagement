namespace BadmintonCourtManagement.DTO
{
    public class PermissionDetailDTO
    {
        private string permissionId = "";
        private string functionId = "";
        
        public enum Option {View, Add, Edit, Delete}
        
        private Option permissionOption = Option.View;

        public string PermissionId { get => permissionId; set => permissionId = value; }
        public string FunctionId { get => functionId; set => functionId = value; }
        public Option PermissionOption { get => permissionOption; set => permissionOption = value; }

        public PermissionDetailDTO() { }

        public PermissionDetailDTO(string permissionId, string functionId, Option permissionOption)
        {
            this.PermissionId = permissionId;
            this.FunctionId = functionId;
            this.PermissionOption = permissionOption;
        }
    }
}