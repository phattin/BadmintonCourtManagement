namespace BadmintonCourtManagement.DTO
{
    public class PermissionDetailDTO
    {
        private string permissionId = "";
        private string functionId = "";
        
        public enum Option {View, Insert, Update, Delete}
        
        private Option option;

        public string PermissionId { get => permissionId; set => permissionId = value; }
        public string FunctionId { get => functionId; set => functionId = value; }
        public Option PermissionOption { get => option; set => option = value; }

        public PermissionDetailDTO() { }

        public PermissionDetailDTO(string permissionId, string functionId, Option option)
        {
            this.PermissionId = permissionId;
            this.FunctionId = functionId;
            this.PermissionOption = option;
        }
    }
}