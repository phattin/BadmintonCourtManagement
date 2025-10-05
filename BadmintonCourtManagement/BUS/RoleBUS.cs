using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{ 
    public class RoleBUS
    {
        private RoleDAO dao = new RoleDAO();

        public List<RoleDTO> GetAllRoles()
        {
            return dao.GetAllRoles();
        }

        public RoleDTO GetRoleById(string roleId)
        {
            return dao.GetRoleById(roleId);
        }

        public bool InsertRole(RoleDTO role)
        {
            var existing = dao.GetRoleById(role.RoleId);
            if (existing != null)
                throw new Exception("RoleId đã tồn tại!");

            return dao.InsertRole(role);
        }

        public bool UpdateRole(RoleDTO role)
        {
            var existing = dao.GetRoleById(role.RoleId);
            if (existing == null)
                throw new Exception("Role không tồn tại!");

            return dao.UpdateRole(role);
        }

        public bool DeleteRole(string roleId)
        {
            var existing = dao.GetRoleById(roleId);
            if (existing == null)
                throw new Exception("Role không tồn tại!");

            return dao.DeleteRole(roleId);
        }
    }
}