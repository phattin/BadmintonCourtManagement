using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;
namespace BadmintonCourtManagement.DAO
{
    public class BillProductDAO
    {
        private DBConnection db = new DBConnection();
        // create
        public bool InsertProductBill(BillProductDTO bill)
        {
            string query = "INSERT INTO BillProduct (BillProductId, EmployeeId, CustomerId, TotalPrice, DateCreated, Status) " +
                           "VALUES (@BillProductId, @EmployeeId, @CustomerId, @TotalPrice, @DateCreated, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", bill.BillProductId);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@CustomerId", bill.CustomerId);
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
                        BillProductId = reader["BillProductId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                        Status = (BillProductDTO.Option)Enum.Parse(typeof(BillProductDTO.Option), reader["Status"].ToString())
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

        public BillProductDTO GetProductBillById(string id)
        {
            string query = "SELECT * FROM BillProduct WHERE BillProductId = @BillProductId";
            BillProductDTO bill;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                bill = new BillProductDTO()
                {
                    BillProductId = reader["BillProductId"].ToString(),
                    EmployeeId = reader["EmployeeId"].ToString(),
                    CustomerId = reader["CustomerId"].ToString(),
                    TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                    DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                    Status = (BillProductDTO.Option)Enum.Parse(typeof(BillProductDTO.Option), reader["Status"].ToString())
                };
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving product bill by ID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return bill;
        }

        public List<BillProductDTO> GetProductBillByCustomerId(string customerId)
        {
            string query = "SELECT * FROM BillProduct WHERE CustomerId = @CustomerId";
            List<BillProductDTO> list = new List<BillProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillProductDTO
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                        Status = (BillProductDTO.Option)Enum.Parse(typeof(BillProductDTO.Option), reader["Status"].ToString())
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving product bills by customer ID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

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
                        CustomerId = reader["CustomerId"].ToString(),
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
                        CustomerId = reader["CustomerId"].ToString(),
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
            string query = "SELECT * FROM BillProduct WHERE CustomerId LIKE @SearchCriteria or EmployeeId LIKE @SearchCriteria or BillProductId LIKE @SearchCriteria";
            List<BillProductDTO> list = new List<BillProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillProductDTO
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                        Status = (BillProductDTO.Option)Enum.Parse(typeof(BillProductDTO.Option), reader["Status"].ToString())
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching product bills: " + ex.Message);
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
            string query = "UPDATE BillProduct SET EmployeeId = @EmployeeId, CustomerId = @CustomerId, TotalPrice = @TotalPrice, DateCreated = @DateCreated, Status = @Status " +
                           "WHERE BillProductId = @BillProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", bill.BillProductId);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@CustomerId", bill.CustomerId);
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
    }
}