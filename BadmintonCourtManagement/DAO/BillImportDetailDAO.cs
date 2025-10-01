using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BillImportDetailDAO
    {
        private DBConnection db = new DBConnection();

        // create
        public bool InsertBillImportDetail(BillImportDetailDTO bill)
        {
            string query = "INSERT INTO billimportproductdetail (ImportBillId, ProductId, Quantity, Price, TotalPrice, Status) VALUES (@ImportBillId, @ProductId, @Quantity, @Price, @TotalPrice, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", bill.ImportBillId);
                cmd.Parameters.AddWithValue("@ProductId", bill.ProductId);
                cmd.Parameters.AddWithValue("@Quantity", bill.Quantity);
                cmd.Parameters.AddWithValue("@Price", bill.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", bill.Status);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting bill import detail: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // read
        public List<BillImportDetailDTO> GetAllDetailImportBills()
        {
            string query = "SELECT * FROM billimportproductdetail";
            List<BillImportDetailDTO> billDetails = new List<BillImportDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BillImportDetailDTO bill = new BillImportDetailDTO
                    {
                        ImportBillId = reader["ImportBillId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        Price = Convert.ToDouble(reader["Price"]),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        Status = reader["Status"].ToString() == "Paid" ? BillImportDetailDTO.Option.Paid : BillImportDetailDTO.Option.Unpaid
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

        public List<BillImportDetailDTO> GetDetailImportByBillImportId(string importBillId)
        {
            string query = "SELECT * FROM billimportproductdetail WHERE ImportBillId = @ImportBillId";
            List<BillImportDetailDTO> billDetails = new List<BillImportDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", importBillId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    billDetails.Add(new BillImportDetailDTO
                    {
                        ImportBillId = reader["ImportBillId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        Price = Convert.ToDouble(reader["Price"]),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        Status = reader["Status"].ToString() == "Paid" ? BillImportDetailDTO.Option.Paid : BillImportDetailDTO.Option.Unpaid
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving bill import details by ImportBillId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return billDetails;
        }

        public List<BillImportDetailDTO> GetDetailImportByProductId(string productId)
        {
            string query = "SELECT * FROM billimportproductdetail WHERE ProductId = @ProductId";
            List<BillImportDetailDTO> billDetails = new List<BillImportDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    billDetails.Add(new BillImportDetailDTO
                    {
                        ImportBillId = reader["ImportBillId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        Price = Convert.ToDouble(reader["Price"]),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        Status = reader["Status"].ToString() == "Paid" ? BillImportDetailDTO.Option.Paid : BillImportDetailDTO.Option.Unpaid
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving bill import details by ProductId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return billDetails;
        }

        // update
        public bool UpdateBillImportDetail(BillImportDetailDTO bill)
        {
            string query = "UPDATE billimportproductdetail SET Quantity = @Quantity, Price = @Price, TotalPrice = @TotalPrice, Status = @Status WHERE ImportBillId = @ImportBillId AND ProductId = @ProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Quantity", bill.Quantity);
                cmd.Parameters.AddWithValue("@Price", bill.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", bill.Status);
                cmd.Parameters.AddWithValue("@ImportBillId", bill.ImportBillId);
                cmd.Parameters.AddWithValue("@ProductId", bill.ProductId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating bill import detail: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // delete
        public bool DeleteBillImportDetail(BillImportDetailDTO bill)
        {
            string query = "DELETE FROM billimportproductdetail WHERE ImportBillId = @ImportBillId AND ProductId = @ProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", bill.ImportBillId);
                cmd.Parameters.AddWithValue("@ProductId", bill.ProductId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting bill import detail: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
    }
}
