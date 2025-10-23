using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class StatisticalDAO
    {
        private DBConnection db = new DBConnection();

        // DTO to hold top selling product information
        public class TopSellingProductDTO
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; } // Use Quantity instead of TotalSold
            public double TotalRevenue { get; set; }
        }

        // Lấy sản phẩm có số lượng bán chạy cao nhất, theo khoảng thời gian
        public List<TopSellingProductDTO> GetTopSellingProducts(DateTime startDate, DateTime endDate, bool sortDescending, string sortBy = "TotalSold")
        {
            // Validate sortBy to prevent SQL injection
            string sortField = sortBy == "TotalRevenue" ? "TotalRevenue" : "TotalSold";
            string sortOrder = sortDescending ? "DESC" : "ASC";

            // Ensure startDate <= endDate
            if (startDate > endDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }

            string query = @"
                SELECT 
                    p.ProductId, 
                    p.ProductName, 
                    SUM(bpd.Quantity) AS TotalSold,
                    SUM(bpd.TotalPrice) AS TotalRevenue
                FROM billproductdetail bpd
                JOIN product p ON bpd.ProductId = p.ProductId
                JOIN billproduct bp ON bpd.BillProductId = bp.BillProductId
                WHERE bp.DateCreated BETWEEN @StartDate AND @EndDate
                GROUP BY p.ProductId, p.ProductName
                ORDER BY {0} {1}";

            // Use string format to safely insert sortField and sortOrder
            query = string.Format(query, sortField, sortOrder);

            List<TopSellingProductDTO> topProducts = new List<TopSellingProductDTO>();

            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TopSellingProductDTO product = new TopSellingProductDTO
                            {
                                ProductId = reader["ProductId"]?.ToString() ?? string.Empty,
                                ProductName = reader["ProductName"]?.ToString() ?? string.Empty,
                                Quantity = reader.IsDBNull(reader.GetOrdinal("TotalSold")) ? 0 : Convert.ToInt32(reader["TotalSold"]),
                                TotalRevenue = reader.IsDBNull(reader.GetOrdinal("TotalRevenue")) ? 0.0 : Convert.ToDouble(reader["TotalRevenue"])
                            };
                            topProducts.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Use consistent error message in Vietnamese
                throw new Exception($"Lỗi khi lấy danh sách sản phẩm bán chạy: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }

            return topProducts;
        }





        // Doanh thu theo khoảng thời gian tiền sân và tiền bán đồ và có kèm theo điều kiện lọc thứ trong tuần
        public class CourtRevenueStatisticsDTO
        {
            public string CourtName { get; set; }
            public double CourtRevenue { get; set; }
        }

        public List<CourtRevenueStatisticsDTO> GetCourtRevenueStatistics(DateTime startDate, DateTime endDate, int filterDayOfWeek)
        {
            if (filterDayOfWeek < 0 || filterDayOfWeek > 7)
            {
                throw new ArgumentException("filterDayOfWeek phải từ 0 (tất cả ngày) đến 7 (Thứ bảy).");
            }

            if (startDate > endDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }

            string query = @"
                SELECT 
                    c.CourtName,
                    SUM(bb.TotalPrice) AS CourtRevenue
                FROM booking bk
                JOIN billbooking bb ON bk.BookingId = bb.BookingId
                JOIN court c ON bk.CourtId = c.CourtId
                WHERE bk.StartTime BETWEEN @StartDate AND @EndDate
                {0}
                GROUP BY c.CourtId, c.CourtName";

            string dayOfWeekCondition = filterDayOfWeek > 0 ? "AND DAYOFWEEK(bk.StartTime) = @FilterDayOfWeek" : "";
            query = string.Format(query, dayOfWeekCondition);

            List<CourtRevenueStatisticsDTO> result = new List<CourtRevenueStatisticsDTO>();

            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    if (filterDayOfWeek > 0)
                    {
                        cmd.Parameters.AddWithValue("@FilterDayOfWeek", filterDayOfWeek);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CourtRevenueStatisticsDTO stats = new CourtRevenueStatisticsDTO
                            {
                                CourtName = reader["CourtName"].ToString(),
                                CourtRevenue = Convert.ToDouble(reader["CourtRevenue"])
                            };
                            result.Add(stats);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thống kê doanh thu sân: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }

            return result;
        }
    }
}