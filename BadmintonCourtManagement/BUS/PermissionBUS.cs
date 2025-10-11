using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.BUS
{
    public class PermissionBUS
    {
        private PermissionDAO permissionDAO = new PermissionDAO();
        public List<PermissionDTO> GetAllPermissions()
        {
            return permissionDAO.GetAllPermissions();
        }

        public PermissionDTO GetPermissionById(string permissionId)
        {
            return permissionDAO.GetPermissionById(permissionId);
        }

        public bool InsertPermission(PermissionDTO permission)
        {
            if (permission.PermissionName.Length > 50)
            {
                MessageBox.Show("Tên quyền không được vượt quá 50 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (permissionDAO.checkNameExists(permission.PermissionName))
            {
                MessageBox.Show("Tên quyền đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return permissionDAO.InsertPermission(permission);
        }

        public bool UpdatePermission(PermissionDTO permission)
        {
            return permissionDAO.UpdatePermission(permission);
        }

        public string GetNextId()
        {
            return permissionDAO.GetNextId();
        }

    }
}
