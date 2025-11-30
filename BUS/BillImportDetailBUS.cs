using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{
    public class BillImportDetailBUS
    {
        private BillImportDetailDAO dao = new BillImportDetailDAO();
        public bool InsertBillImportDetail(BillImportDetailDTO bill)
        {
            return dao.InsertBillImportDetail(bill);
        }
        public List<BillImportDetailDTO> GetAllDetailImportBills()
        {
            return dao.GetAllDetailImportBills();
        }
        public List<BillImportDetailDTO> GetDetailImportBillsByImportBillId(string importBillId)
        {
            return dao.GetDetailImportByBillImportId(importBillId);
        }
        public List<BillImportDetailDTO> GetDetailImportBillsByProductId(string productId)
        {
            return dao.GetDetailImportByProductId(productId);
        }
        public bool UpdateBillImportDetail(BillImportDetailDTO bill)
        {
            return dao.UpdateBillImportDetail(bill);
        }
        public bool DeleteBillImportDetail(BillImportDetailDTO bill)
        {
            return dao.DeleteBillImportDetail(bill);
        }
    }
}