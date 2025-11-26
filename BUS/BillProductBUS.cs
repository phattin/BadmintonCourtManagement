using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;
using System.Security.Permissions;

namespace BadmintonCourtManagement.BUS
{ 
    public class BillProductBUS
    {
        private BillProductDAO dao = new BillProductDAO();
        public string GetMaxId()
        {
            return dao.GetMaxId();
        }
        public bool InsertProductBill(BillProductDTO bill)
        {
            return dao.InsertProductBill(bill);
        }
        public List<BillProductDTO> GetAllProductBills()
        {
            return dao.GetAllProductBills();
        }

        public List<BillProductDTO> GetProductBillByPriceRange(double start, double end)
        {
            return dao.GetProductBillByPriceRange(start, end);
        }
        public List<BillProductDTO> GetProductBillByTimeRange(DateTime startTime, DateTime endTime)
        {
            return dao.GetProductBillByTimeRange(startTime, endTime);
        }
        public List<BillProductDTO> Search(string searchCriteria)
        {
            return dao.Search(searchCriteria);
        }

        public bool UpdateProductBill(BillProductDTO bill)
        {
            return dao.UpdateProductBill(bill);
        }
        public bool DeleteProductBill(string id)
        {
            return dao.DeleteProductBill(id);
        }
        public BillProductDTO GetProductBillById(string id)
        {
            return dao.GetProductBillById(id);
        }
    }
}