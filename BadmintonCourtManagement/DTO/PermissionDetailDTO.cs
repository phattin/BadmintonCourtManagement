namespace BadmintonCourtManagement.DTO
{
    public class PermissionDetailDTO
    {
        private string permissionId = "";
        private string functionId = "";

        public string option = "";

        public string PermissionId { get => permissionId; set => permissionId = value; }
        public string FunctionId { get => functionId; set => functionId = value; }
        public string Option { get => option; set => option = value; }

        public PermissionDetailDTO() { }

        public PermissionDetailDTO(string permissionId, string functionId, string option)
        {
            this.PermissionId = permissionId;
            this.FunctionId = functionId;
            this.Option = option;
        }
    }
}