using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class PermissionDetailBUS
    {
        private PermissionDetailDAO dao = new PermissionDetailDAO();

        public List<PermissionDetailDTO> GetPermissionDetailsByPermissionId(string permissionId)
        {
            return dao.GetPermissionDetailsByPermissionId(permissionId);
        }

        public List<PermissionDetailDTO> GetAllPermissionDetails()
        {
            return dao.GetAllPermissionDetails();
        }

        public List<PermissionDetailDTO> GetPermissionDetailsByOption(string permissionId)
        {
            return dao.GetPermissionDetailsByOption(permissionId);
        }

        public List<PermissionDetailDTO> GetPermissionDetailsByFunctionId(string functionId)
        {
            return dao.GetPermissionDetailsByFunctionId(functionId);
        }

        public bool InsertPermissionDetail(List<PermissionDetailDTO> permissionDetailList)
        {
            foreach(var permissionDetail in permissionDetailList)
                if(!dao.InsertPermissionDetail(permissionDetail))
                    return false;
            return true;
        }
        
        public bool UpdatePermissionDetail(List<PermissionDetailDTO> permissionDetailList)
        {
            if(permissionDetailList.Count == 0) return false;
            if(!dao.DeletePermissionDetailsByPermissionId(permissionDetailList[0].PermissionId))
                return false;
            foreach(var permissionDetail in permissionDetailList)
                if(!dao.InsertPermissionDetail(permissionDetail))
                    return false;
            return true;
        }
    }
}