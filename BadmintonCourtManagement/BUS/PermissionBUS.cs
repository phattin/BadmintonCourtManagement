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
            return permissionDAO.InsertPermission(permission);
        }

        public bool UpdatePermission(PermissionDTO permission)
        {
            return permissionDAO.UpdatePermission(permission);
        }

    }
}
