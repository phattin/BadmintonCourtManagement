using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace BadmintonCourtManagement.DAO
{
    public class BillBookingDAO
    {
        private DBConnection db = new DBConnection();

        // 1. Lấy tất cả (mới nhất trước - mặc định)
        public List<BillBookingDTO> GetAll()
        {
            return GetAllSorted("newest"); // Mặc định là mới nhất
        }

        // 2. Tìm kiếm (vẫn giữ sắp xếp mới nhất)
        public List<BillBookingDTO> Search(string keyword)
        {
            return Search(keyword, "newest");
        }

        // === 4 PHƯƠNG THỨC CHÍNH THEO YÊU CẦU ===
        public List<BillBookingDTO> GetAllNewestFirst()
        {
            return GetAllSorted("newest");
        }

        public List<BillBookingDTO> GetAllOldestFirst()
        {
            return GetAllSorted("oldest");
        }

        public List<BillBookingDTO> GetAllByTotalPriceDesc()
        {
            return GetAllSorted("price_desc");
        }

        public List<BillBookingDTO> GetAllByTotalPriceAsc()
        {
            return GetAllSorted("price_asc");
        }

        // === Phương thức tìm kiếm có sắp xếp ===
        public List<BillBookingDTO> SearchNewestFirst(string keyword)
        {
            return Search(keyword, "newest");
        }

        public List<BillBookingDTO> SearchOldestFirst(string keyword)
        {
            return Search(keyword, "oldest");
        }

        public List<BillBookingDTO> SearchByTotalPriceDesc(string keyword)
        {
            return Search(keyword, "price_desc");
        }

        public List<BillBookingDTO> SearchByTotalPriceAsc(string keyword)
        {
            return Search(keyword, "price_asc");
        }

        // === Phương thức tổng quát có tham số sort ===
        private List<BillBookingDTO> GetAllSorted(string sortBy)
        {
            return ExecuteQuery("", sortBy);
        }

        private List<BillBookingDTO> Search(string keyword, string sortBy)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAllSorted(sortBy);

            return ExecuteQuery(keyword, sortBy);
        }

        // === Query chính (tái sử dụng) ===
        private List<BillBookingDTO> ExecuteQuery(string keyword, string sortBy)
        {
            var list = new List<BillBookingDTO>();

            string whereClause = string.IsNullOrWhiteSpace(keyword) ? "" : @"
                WHERE bb.BillBookingId LIKE @key
                   OR c.CustomerName LIKE @key

                   OR ct.CourtName LIKE @key";

            string orderByClause = sortBy switch
            {
                "newest"     => "ORDER BY b.StartTime DESC",
                "oldest"     => "ORDER BY b.StartTime ASC",
                "price_desc" => "ORDER BY bb.TotalPrice DESC",
                "price_asc"  => "ORDER BY bb.TotalPrice ASC",
                _            => "ORDER BY b.StartTime DESC" // mặc định mới nhất
            };

            string query = $@"
                SELECT 
                    bb.BillBookingId, bb.BookingId, bb.TotalPrice, bb.PrePayment,
                    e.EmployeeName,
                    c.CustomerName, c.Phone,
                    ct.CourtName,
                    b.StartTime, b.EndTime, b.Status AS BookingStatus
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
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                if (!string.IsNullOrWhiteSpace(keyword))
                    cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new BillBookingDTO
                    {
                        BillBookingId = reader["BillBookingId"].ToString(),
                        BookingId = reader["BookingId"].ToString(),
                        EmployeeName = reader["EmployeeName"]?.ToString() ?? "Không xác định",
                        CustomerName = reader["CustomerName"]?.ToString() ?? "Khách lẻ",
                        Phone = reader["Phone"]?.ToString() ?? "",
                        CourtName = reader["CourtName"]?.ToString() ?? "",
                        StartTime = Convert.ToDateTime(reader["StartTime"]),
                        EndTime = Convert.ToDateTime(reader["EndTime"]),
                        BookingStatus = reader["BookingStatus"]?.ToString() ?? "successful",
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        PrePayment = Convert.ToDouble(reader["PrePayment"])
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Lỗi truy vấn hóa đơn sân: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }
        // Thêm vào class BillBookingDAO hiện tại của bạn

public BillBookingDTO GetBillBookingById(string billBookingId)
{
    BillBookingDTO bill = null;
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
            b.Status AS BookingStatus
        FROM billbooking bb
        LEFT JOIN employee e ON bb.EmployeeId = e.EmployeeId
        LEFT JOIN customer c ON bb.CustomerId = c.CustomerId
        LEFT JOIN booking b ON bb.BookingId = b.BookingId
        LEFT JOIN court ct ON b.CourtId = ct.CourtId
        WHERE bb.BillBookingId = @id";

    try
    {
        db.OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, db.Connection);
        cmd.Parameters.AddWithValue("@id", billBookingId);
        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            bill = new BillBookingDTO
            {
                BillBookingId = reader["BillBookingId"].ToString(),
                BookingId = reader["BookingId"].ToString(),
                EmployeeId = reader["EmployeeId"]?.ToString() ?? "",
                EmployeeName = reader["EmployeeName"]?.ToString() ?? "Không xác định",
                CustomerId = reader["CustomerId"]?.ToString() ?? "",
                CustomerName = reader["CustomerName"]?.ToString() ?? "Khách lẻ",
                Phone = reader["Phone"]?.ToString() ?? "",
                CourtId = reader["CourtId"]?.ToString() ?? "",
                CourtName = reader["CourtName"]?.ToString() ?? "",
                StartTime = Convert.ToDateTime(reader["StartTime"]),
                EndTime = Convert.ToDateTime(reader["EndTime"]),
                BookingStatus = reader["BookingStatus"]?.ToString() ?? "successful",
                TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                PrePayment = Convert.ToDouble(reader["PrePayment"])
            };
        }
        reader.Close();
    }
    catch (Exception ex)
    {
        // MessageBox.Show("Lỗi lấy chi tiết hóa đơn sân: " + ex.Message);
    }
    finally
    {
        db.CloseConnection();
    }

    return bill;
}
    }
}