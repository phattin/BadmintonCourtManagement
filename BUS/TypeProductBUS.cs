using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class TypeProductBUS
    {
        private TypeProductDAO dao = new TypeProductDAO();

        public TypeProductDTO GetById(string id)
        {
            return dao.GetById(id);
        }

        public List<TypeProductDTO> GetAllTypeProducts()
        {
            return dao.GetAllTypeProduct();
        }

        public bool InsertTypeProduct(TypeProductDTO typeProduct)
        {
            // Kiểm tra xem typeProduct đã tồn tại chưa
            var existing = dao.GetById(typeProduct.TypeProductId);
            if (existing != null)
                throw new Exception("TypeProduct đã tồn tại!");

            return dao.InsertTypeProduct(typeProduct);
        }

        public bool UpdateTypeProduct(TypeProductDTO typeProduct)
        {
            var existing = dao.GetById(typeProduct.TypeProductId);
            if (existing == null)
                throw new Exception("TypeProduct không tồn tại!");

            return dao.UpdateTypeProduct(typeProduct);
        }

        public bool DeleteTypeProduct(string id)
        {
            var existing = dao.GetById(id);
            if (existing == null)
                throw new Exception("TypeProduct không tồn tại!");

            return dao.DeleteTypeProduct(id);
        }

        // tìm kiếm theo tên 
        public List<TypeProductDTO> GetByTypeName(string keyword)
        {
            return dao.GetByTypeName(keyword);
        }


        public bool IsTypeProductInUse(string typeProductId)
        {
             return dao.IsTypeProductInUse(typeProductId);
        }
        
    }
}