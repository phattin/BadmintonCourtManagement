using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class FunctionBUS
    {
        private FunctionDAO dao = new FunctionDAO();

        public FunctionDTO GetFunctionById(string id)
        {
            return dao.GetById(id);
        }

        public List<FunctionDTO> GetAllFunctions()
        {
            return dao.GetAllFunctions();
        }

        public bool InsertFunction(FunctionDTO function)
        {
            // Kiểm tra xem function đã tồn tại chưa
            var existing = dao.GetById(function.FunctionId);
            if (existing != null)
                throw new Exception("Function đã tồn tại!");

            return dao.InsertFunction(function);
        }
        public bool UpdateFunction(FunctionDTO function)
        {
            var existing = dao.GetById(function.FunctionId);
            if (existing == null)
                throw new Exception("Function không tồn tại!");

            return dao.UpdateFunction(function);
        }
        public bool DeleteFunction(string id)
        {
            var existing = dao.GetById(id);
            if (existing == null)
                throw new Exception("Function không tồn tại!");

            return dao.DeleteFunction(id);
        }
    }
}
