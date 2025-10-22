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
        public class RevenueStatisticsDTO
        {
            public DateTime Date { get; set; }
            public double CourtRevenue { get; set; }
            public double ProductRevenue { get; set; }
            public double TotalRevenue { get; set; } // Sum of CourtRevenue and ProductRevenue
        }

        public List<RevenueStatisticsDTO> GetRevenueStatistics(DateTime startDate, DateTime endDate, int filterDayOfWeek)
        {
            // Validate filterDayOfWeek
            if (filterDayOfWeek < 1 || filterDayOfWeek > 7)
            {
                throw new ArgumentException("filterDayOfWeek phải từ 1 (Chủ nhật) đến 7 (Thứ bảy).");
            }

            // Ensure startDate <= endDate
            if (startDate > endDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }

            string query = @"
                SELECT 
                    DATE(bk.StartTime) AS Date,
                    SUM(bb.TotalPrice) AS CourtRevenue,
                    COALESCE((
                        SELECT SUM(bpd.Quantity * bpd.UnitPrice)
                        FROM billproductdetail bpd
                        JOIN billproduct bp ON bpd.BillProductId = bp.BillProductId
                        WHERE DATE(bp.DateCreated) = DATE(bk.StartTime)
                        AND bp.DateCreated BETWEEN @StartDate AND @EndDate
                    ), 0) AS ProductRevenue
                FROM booking bk
                JOIN billbooking bb ON bk.BookingId = bb.BookingId
                WHERE bk.StartTime BETWEEN @StartDate AND @EndDate
                    AND DAYOFWEEK(bk.StartTime) = @FilterDayOfWeek
                GROUP BY DATE(bk.StartTime)";

            List<RevenueStatisticsDTO> result = new List<RevenueStatisticsDTO>();

            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@FilterDayOfWeek", filterDayOfWeek);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double courtRevenue = Convert.ToDouble(reader["CourtRevenue"]);
                            double productRevenue = Convert.ToDouble(reader["ProductRevenue"]);
                            RevenueStatisticsDTO stats = new RevenueStatisticsDTO
                            {
                                Date = Convert.ToDateTime(reader["Date"]),
                                CourtRevenue = courtRevenue,
                                ProductRevenue = productRevenue,
                                TotalRevenue = courtRevenue + productRevenue // Calculate TotalRevenue
                            };
                            result.Add(stats);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thống kê doanh thu: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }

            return result;
        }
    }
}