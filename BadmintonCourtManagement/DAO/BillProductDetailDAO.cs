using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BillProductDetailDAO
    {
        private DBConnection db = new DBConnection();

        // create
        public bool InsertBillProductDetail(BillProductDetailDTO bill)
        {
            string query = "INSERT INTO billimportproductdetail (BillProductId, ProductId, Quantity, Price, TotalPrice) VALUES (@BillProductId, @ProductId, @Quantity, @Price, @TotalPrice)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", bill.BillProductId);
                cmd.Parameters.AddWithValue("@ProductId", bill.ProductId);
                cmd.Parameters.AddWithValue("@Quantity", bill.Quantity);
                cmd.Parameters.AddWithValue("@Price", bill.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting bill product detail: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // read
        public List<BillProductDetailDTO> GetAllDetailProductBills()
        {
            string query = "SELECT * FROM billproductdetail";
            List<BillProductDetailDTO> billDetails = new List<BillProductDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BillProductDetailDTO bill = new BillProductDetailDTO
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = int.Parse(reader["Quantity"].ToString()),
                        Price = double.Parse(reader["Price"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                    };
                    billDetails.Add(bill);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving bill import details: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return billDetails;
        }

        public List<BillProductDetailDTO> GetDetailByBillProductId(string billProductId)
        {
            string query = "SELECT * FROM billproductdetail WHERE BillProductId = @BillProductId";
            List<BillProductDetailDTO> billDetails = new List<BillProductDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", billProductId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    billDetails.Add(new BillProductDetailDTO
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = int.Parse(reader["Quantity"].ToString()),
                        Price = double.Parse(reader["Price"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving bill product details by BillProductId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return billDetails;
        }

        public List<BillProductDetailDTO> GetDetailByProductId(string productId)
        {
            string query = "SELECT * FROM billproductdetail WHERE ProductId = @ProductId";
            List<BillProductDetailDTO> billDetails = new List<BillProductDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    billDetails.Add(new BillProductDetailDTO
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = int.Parse(reader["Quantity"].ToString()),
                        Price = double.Parse(reader["Price"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving bill product details by ProductId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return billDetails;
        }

        // update
        public bool UpdateBillProductDetail(BillProductDetailDTO bill)
        {
            string query = "UPDATE billproductdetail SET Quantity = @Quantity, Price = @Price, TotalPrice = @TotalPrice WHERE BillProductId = @BillProductId AND ProductId = @ProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Quantity", bill.Quantity);
                cmd.Parameters.AddWithValue("@Price", bill.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@BillProductId", bill.BillProductId);
                cmd.Parameters.AddWithValue("@ProductId", bill.ProductId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating bill product detail: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // delete
        public bool DeleteBillProductDetail(BillProductDetailDTO bill)
        {
            string query = "DELETE FROM billproductdetail WHERE BillProductId = @BillProductId AND ProductId = @ProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", bill.BillProductId);
                cmd.Parameters.AddWithValue("@ProductId", bill.ProductId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting bill product detail: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
    }
}
