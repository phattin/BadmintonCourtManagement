using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BadmintonCourtManagement.DAO
{
    public class hoadonDAO
    {
        private readonly DBConnection db = new DBConnection();

        // ==================== CÁC PHƯƠNG THỨC CÔNG KHAI ====================

        public List<hoadonDTO> GetAll() => GetAllSorted("newest");

        public List<hoadonDTO> GetAllNewestFirst() => GetAllSorted("newest");
        public List<hoadonDTO> GetAllOldestFirst() => GetAllSorted("oldest");
        public List<hoadonDTO> GetAllByTotalPriceDesc() => GetAllSorted("price_desc");
        public List<hoadonDTO> GetAllByTotalPriceAsc() => GetAllSorted("price_asc");

        public List<hoadonDTO> Search(string keyword) => Search(keyword, "newest");
        public List<hoadonDTO> SearchNewestFirst(string keyword) => Search(keyword, "newest");
        public List<hoadonDTO> SearchOldestFirst(string keyword) => Search(keyword, "oldest");
        public List<hoadonDTO> SearchByTotalPriceDesc(string keyword) => Search(keyword, "price_desc");
        public List<hoadonDTO> SearchByTotalPriceAsc(string keyword) => Search(keyword, "price_asc");

        // Lấy chi tiết 1 hóa đơn theo ID
        public hoadonDTO GetById(string billBookingId)
        {
            if (string.IsNullOrWhiteSpace(billBookingId))
                return null;

            string query = @"
                SELECT 
                    bb.BillBookingId,
                    bb.BookingId,
                    bb.EmployeeId,
                    e.EmployeeName,
                    bb.CustomerId,
                    c.CustomerName,
                    c.Phone,
                    bb.TotalPrice,
                    bb.PrePayment,
                    b.CourtId,
                    ct.CourtName,
                    b.StartTime,
                    b.EndTime,
                    b.Status
                FROM billbooking bb
                LEFT JOIN employee e ON bb.EmployeeId = e.EmployeeId
                LEFT JOIN customer c ON bb.CustomerId = c.CustomerId
                LEFT JOIN booking b ON bb.BookingId = b.BookingId
                LEFT JOIN court ct ON b.CourtId = ct.CourtId
                WHERE bb.BillBookingId = @id
                LIMIT 1";

            try
            {
                db.OpenConnection();
                using var cmd = new MySqlCommand(query, db.Connection);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", billBookingId);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return MapReaderToDTO(reader);
                }
            }
            catch (Exception ex)
            {
                // Ghi log thay vì MessageBox
                Console.WriteLine($"[BillBookingDAO] Lỗi GetById: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }

            return null;
        }

        // ==================== PHƯƠNG THỨC RIÊNG (TÁp dụng DRY) ====================

        private List<hoadonDTO> GetAllSorted(string sortBy) => ExecuteQuery("", sortBy);

        private List<hoadonDTO> Search(string keyword, string sortBy)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAllSorted(sortBy);

            return ExecuteQuery($"%{keyword.Trim()}%", sortBy);
        }

        private List<hoadonDTO> ExecuteQuery(string keyword, string sortBy)
        {
            var list = new List<hoadonDTO>();

            string whereClause = string.IsNullOrEmpty(keyword) ? "" : @"
                WHERE bb.BillBookingId LIKE @key
                   OR c.CustomerName LIKE @key
                   OR c.Phone LIKE @key
                   OR ct.CourtName LIKE @key";

            string orderByClause = sortBy switch
            {
                "newest"     => "ORDER BY b.StartTime DESC",
                "oldest"     => "ORDER BY b.StartTime ASC",
                "price_desc" => "ORDER BY bb.TotalPrice DESC",
                "price_asc"  => "ORDER BY bb.TotalPrice ASC",
                _            => "ORDER BY b.StartTime DESC"
            };

            string query = $@"
                SELECT 
                    bb.BillBookingId,
                    bb.BookingId,
                    bb.EmployeeId,
                    e.EmployeeName,
                    bb.CustomerId,
                    c.CustomerName,
                    c.Phone,
                    bb.TotalPrice,
                    bb.PrePayment,
                    b.CourtId,
                    ct.CourtName,
                    b.StartTime,
                    b.EndTime,
                    b.Status
                FROM billbooking bb
                LEFT JOIN employee e ON bb.EmployeeId = e.EmployeeId
                LEFT JOIN customer c ON bb.CustomerId = c.CustomerId
                LEFT JOIN booking b ON bb.BookingId = b.BookingId
                LEFT JOIN court ct ON b.CourtId = ct.CourtId
                {whereClause}
                {orderByClause}";

            try
            {
                db.OpenConnection();
                using var cmd = new MySqlCommand(query, db.Connection);

                if (!string.IsNullOrEmpty(keyword))
                    cmd.Parameters.AddWithValue("@key", keyword);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(MapReaderToDTO(reader));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[BillBookingDAO] Lỗi truy vấn: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

        // Tách riêng việc map để tái sử dụng (DRY + dễ bảo trì)
        private hoadonDTO MapReaderToDTO(MySqlDataReader reader)
        {
            return new hoadonDTO
            {
                BillBookingId = reader["BillBookingId"].ToString() ?? "",
                BookingId = reader["BookingId"].ToString() ?? "",
                EmployeeId = reader["EmployeeId"]?.ToString() ?? "",
                EmployeeName = reader["EmployeeName"]?.ToString() ?? "Không xác định",
                CustomerId = reader["CustomerId"]?.ToString() ?? "",
                CustomerName = reader["CustomerName"]?.ToString() ?? "Khách lẻ",
                Phone = reader["Phone"]?.ToString() ?? "",
                CourtId = reader["CourtId"]?.ToString() ?? "",
                CourtName = reader["CourtName"]?.ToString() ?? "Chưa xác định",
                StartTime = Convert.ToDateTime(reader["StartTime"]),
                EndTime = Convert.ToDateTime(reader["EndTime"]),
                Status = Enum.TryParse<hoadonDTO.BookingStatus>(
                    reader["Status"]?.ToString(), out var status) ? status : hoadonDTO.BookingStatus.successful,
                TotalPrice = Convert.ToDouble(reader["TotalPrice"] ?? 0),
                PrePayment = Convert.ToDouble(reader["PrePayment"] ?? 0),
                DateCreated = DateTime.Now // Nếu bạn thêm cột này vào DB thì dùng, nếu không thì để Now
            };
        }
    }
}