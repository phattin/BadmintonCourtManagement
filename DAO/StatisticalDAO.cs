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
            public int TotalSold { get; set; }
            public double TotalRevenue { get; set; }
        }

        // Lấy sản phẩm có số lượng bán chạy cao nhất, theo khoảng thời gian
        public List<TopSellingProductDTO> GetTopSellingProducts(DateTime startDate, DateTime endDate, int topN, bool sortDescending)
        {
            string sortOrder = sortDescending ? "DESC" : "ASC";
            string query = @"
                SELECT 
                    p.ProductId, 
                    p.ProductName, 
                    SUM(bpd.Quantity) AS TotalSold,
                    SUM(bpd.Quantity * bpd.UnitPrice) AS TotalRevenue
                FROM billproductdetail bpd
                JOIN product p ON bpd.ProductId = p.ProductId
                JOIN billproduct bp ON bpd.BillProductId = bp.BillProductId
                WHERE bp.DateCreated BETWEEN @StartDate AND @EndDate
                GROUP BY p.ProductId, p.ProductName
                ORDER BY TotalSold " + sortOrder + @"
                LIMIT @TopN";

            List<TopSellingProductDTO> topProducts = new List<TopSellingProductDTO>();

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@TopN", topN);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TopSellingProductDTO product = new TopSellingProductDTO
                    {
                        ProductId = reader["ProductId"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        TotalSold = Convert.ToInt32(reader["TotalSold"]),
                        TotalRevenue = Convert.ToDouble(reader["TotalRevenue"])
                    };
                    topProducts.Add(product);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving top selling products: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return topProducts;
        }

        // doanh thu theo khoảng thời gian tiền sân và tiền bán đồ và có kèm theo điều kiện lọc thứ trong tuần
        public class RevenueStatisticsDTO
        {
            public DateTime Date { get; set; }
            public double CourtRevenue { get; set; }
            public double ProductRevenue { get; set; }
            public double TotalRevenue { get; set; }
        }

public List<RevenueStatisticsDTO> GetRevenueStatistics(DateTime startDate, DateTime endDate, int filterDayOfWeek)
        {
            switch (filterDayOfWeek)
            {
                case 1: // Chủ nhật
                case 2: // Thứ hai
                case 3: // Thứ ba
                case 4: // Thứ tư
                case 5: // Thứ năm
                case 6: // Thứ sáu
                case 7: // Thứ bảy
                    break;
                default:
                    throw new ArgumentException("filterDayOfWeek phải từ 1 (Chủ nhật) đến 7 (Thứ bảy).");
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
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@FilterDayOfWeek", filterDayOfWeek);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RevenueStatisticsDTO stats = new RevenueStatisticsDTO
                    {
                        Date = Convert.ToDateTime(reader["Date"]),
                        CourtRevenue = Convert.ToDouble(reader["CourtRevenue"]),
                        ProductRevenue = Convert.ToDouble(reader["ProductRevenue"])
                    };
                    result.Add(stats);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thống kê doanh thu: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return result;
        }
    }


}