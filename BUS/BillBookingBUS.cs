using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;
using System.Collections.Generic;

namespace BadmintonCourtManagement.BUS
{
    public class BillBookingBUS
    {
        // Singleton DAO instance - Tái sử dụng kết nối, tránh tạo mới liên tục
        private static readonly BillBookingDAO dao = new BillBookingDAO();

        // ==================== LẤY DO DÙNG static + readonly ====================
        // - Không cần tạo mới DAO mỗi lần gọi
        // - Thread-safe trong môi trường WinForms
        // - Tăng hiệu suất, giảm garbage collection

        // Hiển thị tất cả (mới nhất trước)
        public static List<BillBookingDTO> GetAll() => dao.GetAll();

        // Tìm kiếm (mới nhất trước)
        public static List<BillBookingDTO> Search(string keyword) => dao.Search(keyword);

        // Các cách sắp xếp danh sách toàn bộ
        public static List<BillBookingDTO> GetAllNewest()           => dao.GetAllNewestFirst();
        public static List<BillBookingDTO> GetAllOldest()            => dao.GetAllOldestFirst();
        public static List<BillBookingDTO> GetAllByPriceDesc()       => dao.GetAllByTotalPriceDesc();
        public static List<BillBookingDTO> GetAllByPriceAsc()        => dao.GetAllByTotalPriceAsc();

        // Các cách tìm kiếm + sắp xếp
        public static List<BillBookingDTO> SearchNewest(string keyword)      => dao.SearchNewestFirst(keyword);
        public static List<BillBookingDTO> SearchOldest(string keyword)      => dao.SearchOldestFirst(keyword);
        public static List<BillBookingDTO> SearchByPriceDesc(string keyword) => dao.SearchByTotalPriceDesc(keyword);
        public static List<BillBookingDTO> SearchByPriceAsc(string keyword)  => dao.SearchByTotalPriceAsc(keyword);

        // Lấy chi tiết 1 hóa đơn đặt sân theo ID
        public static BillBookingDTO GetById(string billBookingId)
        {
            if (string.IsNullOrWhiteSpace(billBookingId))
                return null;

            return dao.GetById(billBookingId);
        }

        // Bonus: Lấy danh sách theo ngày (rất hay dùng cho báo cáo)
        public static List<BillBookingDTO> GetByDateRange(DateTime fromDate, DateTime toDate)
        {
            // Bạn có thể mở rộng DAO để hỗ trợ phương thức này sau
            // Hiện tại tạm trả về tất cả rồi lọc ở BUS (vẫn ổn cho dữ liệu nhỏ)
            return dao.GetAll()
                .FindAll(b => b.StartTime.Date >= fromDate.Date && b.StartTime.Date <= toDate.Date);
        }

        // Bonus: Thống kê doanh thu sân theo ngày/tháng
        public static double GetTotalRevenueByDate(DateTime date)
        {
            return dao.GetAll()
                .FindAll(b => b.StartTime.Date == date.Date)
                .Sum(b => b.TotalPrice);
        }
    }
}