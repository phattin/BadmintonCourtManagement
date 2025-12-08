using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;
using System.Collections.Generic;

namespace BadmintonCourtManagement.BUS
{
    public class BillBookingBUS
    {
        private static BillBookingDAO dao = new BillBookingDAO();

        // Hiển thị toàn bộ
        public static List<BillBookingDTO> GetAll()
        {
            return dao.GetAll();
        }

        // Tìm kiếm
        public static List<BillBookingDTO> Search(string keyword)
        {
            return dao.Search(keyword);
        }

        public static List<BillBookingDTO> GetAllNewest()        => dao.GetAllNewestFirst();
public static List<BillBookingDTO> GetAllOldest()        => dao.GetAllOldestFirst();
public static List<BillBookingDTO> GetAllPriceDesc()     => dao.GetAllByTotalPriceDesc();
public static List<BillBookingDTO> GetAllPriceAsc()      => dao.GetAllByTotalPriceAsc();

public static List<BillBookingDTO> SearchNewest(string k)   => dao.SearchNewestFirst(k);
public static List<BillBookingDTO> SearchOldest(string k)   => dao.SearchOldestFirst(k);
public static List<BillBookingDTO> SearchPriceDesc(string k)=> dao.SearchByTotalPriceDesc(k);
public static List<BillBookingDTO> SearchPriceAsc(string k) => dao.SearchByTotalPriceAsc(k);
    


       
// Trong BillBookingBUS.cs
public BillBookingDTO GetBillBookingById(string id)
{
    var dao = new BillBookingDAO();
    return dao.GetBillBookingById(id);
}

        // Các phương thức khác (nếu có): GetAllNewest, SearchByTotalPriceDesc, v.v.
    
    }
}