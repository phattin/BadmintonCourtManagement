using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class PermissionBUS
    {
        private PermissionDAO dao = new PermissionDAO();

        public List<PermissionDTO> GetAllPermissions()
        {
            return dao.GetAllPermissions();
        }

        public PermissionDTO GetPermissionById(string id)
        {
            return dao.GetPermissionById(id);
        }

        public bool InsertPermission(PermissionDTO permission)
        {
            // Kiểm tra xem permission đã tồn tại chưa
            var existing = dao.GetPermissionById(permission.PermissionId);
            if (existing != null)
                throw new Exception("Permission đã tồn tại!");
            return dao.InsertPermission(permission);
        }

        public bool UpdatePermission(PermissionDTO permission)
        {
            var existing = dao.GetPermissionById(permission.PermissionId);
            if (existing == null)
                throw new Exception("Permission không tồn tại!");
            return dao.UpdatePermission(permission);
        }

        public bool DeletePermission(string id)
        {
            var existing = dao.GetPermissionById(id);
            if (existing == null)
                throw new Exception("Permission không tồn tại!");
            return dao.DeletePermission(id);
        }
    }
 }