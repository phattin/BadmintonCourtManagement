using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class SupplierBUS
    {
        private SupplierDAO dao =  new SupplierDAO();

        public SupplierDTO GetSupplierById(string id)
        {
            return dao.GetSupplierById(id);
        }

        public List<SupplierDTO> GetAllSuppliers()
        {
            return dao.GetAllSuppliers();
        }

        public List<SupplierDTO> Search(string keyword)
        {
            return dao.Search(keyword);
        }



        public bool InsertSupplier(SupplierDTO supplier)
        {
            // Kiểm tra xem supplier đã tồn tại chưa
            var existing = dao.GetSupplierById(supplier.Id);
            if (existing != null)
                throw new Exception("Supplier đã tồn tại!");

            return dao.InsertSupplier(supplier);
        }

        public bool UpdateSupplier(SupplierDTO supplier)
        {
            var existing = dao.GetSupplierById(supplier.Id);
            if (existing == null)
                throw new Exception("Supplier không tồn tại!");

            return dao.UpdateSupplier(supplier);
        }

        public bool DeleteSupplier(string id)
        {
            var existing = dao.GetSupplierById(id);
            if (existing == null)
                throw new Exception("Supplier không tồn tại!");

            return dao.DeleteSupplier(id);
        }
    }
}