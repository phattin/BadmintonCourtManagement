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

        public bool DeletePermissionDetail(PermissionDetailDTO permissionDetail)
        {
            var existing = dao.GetPermissionDetailsByPermissionId(permissionDetail.PermissionId)
                              .Find(pd => pd.FunctionId == permissionDetail.FunctionId && pd.PermissionOption == permissionDetail.PermissionOption);
            if (existing == null)
                throw new Exception("Chi tiết quyền không tồn tại!");

            return dao.DeletePermissionDetail(permissionDetail);
        }

        public bool InsertPermissionDetail(List<PermissionDetailDTO> permissionDetailList)
        {
            foreach(var permissionDetail in permissionDetailList)
            {
                if(!dao.InsertPermissionDetail(permissionDetail))
                {
                    MessageBox.Show("Thêm chi tiết quyền thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        
        public bool UpdatePermissionDetail(PermissionDetailDTO permissionDetail)
        {
            var existing = dao.GetPermissionDetailsByPermissionId(permissionDetail.PermissionId)
                              .Find(pd => pd.FunctionId == permissionDetail.FunctionId && pd.PermissionOption == permissionDetail.PermissionOption);
            if (existing == null)
                throw new Exception("Chi tiết quyền không tồn tại!");

            return dao.UpdatePermissionDetail(permissionDetail);
        }
    }
}