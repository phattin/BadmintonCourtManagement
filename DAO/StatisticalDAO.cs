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

        // DTO to hold court revenue information
        public class CourtRevenueDTO
        {
            public string CourtId { get; set; }
            public string CourtName { get; set; }
            public double TotalRevenue { get; set; }
            public double BookingCount { get; set; } 
        }

        // Lấy doanh thu của sân theo khoảng thời gian, với tùy chọn lọc tên sân và sắp xếp
public List<CourtRevenueDTO> GetCourtRevenue(DateTime startDate, DateTime endDate, string courtNameFilter = null, bool sortDescending = true)
{
    if (startDate > endDate)
        throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");

    string query = @"
        SELECT 
            c.CourtId,
            c.CourtName,
            COALESCE(SUM(p.Price * TIMESTAMPDIFF(HOUR, b.StartTime, b.EndTime)), 0) AS TotalRevenue,
            COUNT(b.BookingId) AS BookingCount
        FROM 
            court c
        LEFT JOIN 
            booking b ON c.CourtId = b.CourtId 
            AND b.StartTime >= @StartDate 
            AND b.StartTime < @EndDatePlusOne
        LEFT JOIN 
            pricerule p ON 
                (p.StartDate IS NULL OR b.StartTime >= p.StartDate)
                AND (p.EndDate IS NULL OR b.StartTime < p.EndDate)
                AND TIME(b.StartTime) >= p.StartTime
                AND TIME(b.StartTime) < p.EndTime
                AND (
                    (p.EndType = 'Weekday' AND WEEKDAY(b.StartTime) BETWEEN 0 AND 4)
                    OR (p.EndType = 'Weekend' AND WEEKDAY(b.StartTime) IN (5,6))
                    OR p.EndType = 'Holiday'
                )
                AND p.Status = 'Đang áp dụng'
        WHERE 
            1=1";

    if (!string.IsNullOrEmpty(courtNameFilter))
    {
        query += " AND c.CourtName LIKE @CourtNameFilter";
    }

    query += @"
        GROUP BY c.CourtId, c.CourtName
        ORDER BY TotalRevenue " + (sortDescending ? "DESC" : "ASC");

    var courtRevenues = new List<CourtRevenueDTO>();

    try
    {
        db.OpenConnection();
        using (var cmd = new MySqlCommand(query, db.Connection))
        {
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDatePlusOne", endDate.AddDays(1));

            if (!string.IsNullOrEmpty(courtNameFilter))
                cmd.Parameters.AddWithValue("@CourtNameFilter", $"%{courtNameFilter}%");

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var court = new CourtRevenueDTO
                    {
                        CourtId = reader["CourtId"]?.ToString() ?? string.Empty,
                        CourtName = reader["CourtName"]?.ToString() ?? string.Empty,
                        TotalRevenue =  Convert.ToDouble(reader["TotalRevenue"]),
                        BookingCount = Convert.ToInt32(reader["BookingCount"])
                    };

                    courtRevenues.Add(court);
                }
            }
        }
    }
    catch (Exception ex)
    {
        throw new Exception($"Lỗi khi lấy doanh thu sân: {ex.Message}", ex);
    }
    finally
    {
        db.CloseConnection();
    }

    return courtRevenues;
}
    }
}