using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.BUS
{
    public class BillProductDetailBUS
    {
        BillProductDetailDAO dao = new BillProductDetailDAO();
        public bool InsertBillProductDetail(BillProductDetailDTO bill)
        {
            return dao.InsertBillProductDetail(bill);
        }
        public List<BillProductDetailDTO> GetAllDetailProductBills()
        {
            return dao.GetAllDetailProductBills();
        }
        public List<BillProductDetailDTO> GetDetailByBillProductId(string billProductId) {
            return dao.GetDetailByBillProductId(billProductId);
        }
        public List<BillProductDetailDTO> GetDetailByProductId(string productId)
        {
            return dao.GetDetailByProductId(productId);
        }
        public bool UpdateBillProductDetail(BillProductDetailDTO bill)
        {
            return dao.UpdateBillProductDetail(bill);
        }
        public bool DeleteBillProductDetail(BillProductDetailDTO bill)
        {
            return dao.DeleteBillProductDetail(bill);
        }
    }
}