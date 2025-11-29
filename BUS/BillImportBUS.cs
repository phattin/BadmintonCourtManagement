using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class BillImportBUS
    {
        private BillImportDAO dao = new BillImportDAO();

	public string GetMaxId() {
		return dao.GetMaxId();
	}
        public List<ImportBillDTO> GetAllImportBills()
        {
            return dao.GetAllImportBills();
        }

        public ImportBillDTO GetBillImportById(string id)
        {
            return dao.GetImportBillById(id);
        }

        public bool InsertBillImport(ImportBillDTO billImport)
        {
            var existing = dao.GetImportBillById(billImport.ImportBillId);
            if (existing != null)
                throw new Exception("Bill import đã tồn tại!");
            return dao.InsertImportBill(billImport);
        }

        public bool UpdateBillImport(ImportBillDTO billImport)
        {
            var existing = dao.GetImportBillById(billImport.ImportBillId);
            if (existing == null)
                throw new Exception("Bill import không tồn tại!");

            return dao.UpdateImportBill(billImport);
        }

        public bool DeleteBillImport(string id)
        {
            var existing = dao.GetImportBillById(id);
            if (existing == null)
                throw new Exception("Bill import không tồn tại!");

            return dao.DeleteOneImportBill(id);
        }

        public List<ImportBillDTO> SearchImportBills(string keyword)
        {
            return dao.SearchImportBill(keyword);
        }

        public List<ImportBillDTO> GetImportBillBySupplierId(string supplierId)
        {
            return dao.GetImportBillBySupplierId(supplierId);
        }

        public List<ImportBillDTO> GetImportBillByDateRange(DateTime startDate, DateTime endDate)
        {
            return dao.GetImportBillByDateRange(startDate, endDate);
        }
    }
}
