using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;
namespace BadmintonCourtManagement.DAO
{
    public class BillProductDAO
    {
        private DBConnection db = new DBConnection();

        public string GetMaxId()
        {
            string getMaxIdQuery = "SELECT MAX(BillProductId) FROM BillProduct WHERE BillProductId LIKE 'BP%'";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(getMaxIdQuery, db.Connection);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving max BillProductId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // create
        public bool InsertProductBill(BillProductDTO bill)
        {
            string query = "INSERT INTO BillProduct (BillProductId, EmployeeId, TotalPrice, DateCreated, Status) " +
                           "VALUES (@BillProductId, @EmployeeId, @TotalPrice, @DateCreated, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@BillProductId", bill.BillProductId);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                // set creation time here so DB always uses current time
                bill.DateCreated = DateTime.Now;

                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@DateCreated", bill.DateCreated);
                cmd.Parameters.AddWithValue("@Status", bill.Status.ToString());
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting product bill: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // read
        public List<BillProductDTO> GetAllProductBills()
        {
            string query = "SELECT * FROM BillProduct";
            List<BillProductDTO> list = new List<BillProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillProductDTO
                    {
                        BillProductId = reader["BillProductId"]?.ToString() ?? string.Empty,
                EmployeeId = reader["EmployeeId"]?.ToString() ?? string.Empty,
                TotalPrice = reader["TotalPrice"] is DBNull ? 0.0 : Convert.ToDouble(reader["TotalPrice"]),
                DateCreated = reader["DateCreated"] is DBNull ? DateTime.MinValue : Convert.ToDateTime(reader["DateCreated"]),
                
                // Safely parse nullable enum
                Status = reader["Status"] is DBNull || reader["Status"] == null 
                    ? BillProductDTO.Option.Unpaid  // or make Status nullable: Option?
                    : Enum.Parse<BillProductDTO.Option>(reader["Status"].ToString(), ignoreCase: true)
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving product bills: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        // Note: GetProductBillById implemented later with a safe reader.Read() check.

        public List<BillProductDTO> GetProductBillByPriceRange(double start, double end)
        {
            string query = "SELECT * FROM BillProduct WHERE TotalPrice BETWEEN @Start AND @End";
            List<BillProductDTO> list = new List<BillProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Start", start);
                cmd.Parameters.AddWithValue("@End", end);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillProductDTO
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                        Status = (BillProductDTO.Option)Enum.Parse(typeof(BillProductDTO.Option), reader["Status"].ToString())
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving product bills by price range: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        public List<BillProductDTO> GetProductBillByTimeRange(DateTime startTime, DateTime endTime)
        {
            string query = "SELECT * FROM BillProduct WHERE DateCreated BETWEEN @StartTime AND @EndTime";
            List<BillProductDTO> list = new List<BillProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillProductDTO
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                        Status = (BillProductDTO.Option)Enum.Parse(typeof(BillProductDTO.Option), reader["Status"].ToString())
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving product bills by time range: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

public List<BillProductDTO> Search(string searchCriteria)
{
    // Nếu để trống thì trả về rỗng hoặc có thể để trả tất cả (tùy yêu cầu)
    if (string.IsNullOrWhiteSpace(searchCriteria))
        return new List<BillProductDTO>();

    // Chỉ tìm theo 2 trường chính xác (mã hóa đơn hoặc mã nhân viên)
    string query = @"
        SELECT bp.*, e.EmployeeName, c.CustomerName 
        FROM billproduct bp
        LEFT JOIN employee e ON bp.EmployeeId = e.EmployeeId
        LEFT JOIN customer c ON bp.CustomerId = c.CustomerId
        WHERE bp.BillProductId LIKE @SearchCriteria 
           OR bp.EmployeeId LIKE @SearchCriteria";

    var list = new List<BillProductDTO>();

    try
    {
        db.OpenConnection();
        using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
        {
            cmd.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria.Trim() + "%");

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new BillProductDTO
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        DateCreated = Convert.ToDateTime(reader["DateCreated"])
                    
                    });
                }
            }
        }
    }
    catch (Exception ex)
    {
        throw new Exception("Lỗi khi tìm kiếm hóa đơn bán sản phẩm: " + ex.Message, ex);
    }
    finally
    {
        db.CloseConnection();
    }

    return list;
}

        // update
        public bool UpdateProductBill(BillProductDTO bill)
        {
            string query = "UPDATE BillProduct SET EmployeeId = @EmployeeId, TotalPrice = @TotalPrice, DateCreated = @DateCreated, Status = @Status " +
                           "WHERE BillProductId = @BillProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", bill.BillProductId);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@DateCreated", bill.DateCreated);
                cmd.Parameters.AddWithValue("@Status", bill.Status);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating product bill: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // delete
        public bool DeleteProductBill(string id)
        {
            string query = "DELETE FROM BillProduct WHERE BillProductId = @BillProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", id);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting product bill: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
        public BillProductDTO GetProductBillById(string id)
        {
            string query = "SELECT * FROM BillProduct WHERE BillProductId = @BillProductId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        throw new Exception($"BillProduct with id '{id}' not found.");

                    var bill = new BillProductDTO();

                    int idxBillId = reader.GetOrdinal("BillProductId");
                    int idxEmployee = reader.GetOrdinal("EmployeeId");
                    int idxTotal = reader.GetOrdinal("TotalPrice");
                    int idxDate = reader.GetOrdinal("DateCreated");
                    int idxStatus = reader.GetOrdinal("Status");

                    bill.BillProductId = reader.IsDBNull(idxBillId) ? string.Empty : reader.GetString(idxBillId);
                    bill.EmployeeId = reader.IsDBNull(idxEmployee) ? string.Empty : reader.GetString(idxEmployee);
                    bill.TotalPrice = reader.IsDBNull(idxTotal) ? 0.0 : reader.GetDouble(idxTotal);
                    bill.DateCreated = reader.IsDBNull(idxDate) ? DateTime.MinValue : reader.GetDateTime(idxDate);

                    string statusStr = reader.IsDBNull(idxStatus) ? string.Empty : reader.GetString(idxStatus);
                    if (!Enum.TryParse<BillProductDTO.Option>(statusStr, out var parsedStatus))
                        parsedStatus = default;
                    bill.Status = parsedStatus;

                    return bill;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving product bill by ID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}