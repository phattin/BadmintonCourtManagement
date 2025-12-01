using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonCourtManagement.DAO
{
    public class StorageDAO
    {
        private DBConnection db = new DBConnection();

        // create
        public bool InsertStorage(StorageDTO storage)
        {
            string query = "INSERT INTO storage (StorageId, ImportBillDetailId, ProductId, Quantity, Price, TotalPrice, CreatedAt, Status) VALUES (@StorageId, @ImportBillDetailId, @ProductId, @Quantity, @Price, @TotalPrice, @CreatedAt, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@StorageId", storage.StorageId);
                cmd.Parameters.AddWithValue("@ImportBillId", storage.ImportBillDetailId);
                cmd.Parameters.AddWithValue("@ProductId", storage.ProductId);
                cmd.Parameters.AddWithValue("@Quantity", storage.Quantity);
                cmd.Parameters.AddWithValue("@Price", storage.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", storage.TotalPrice);
                cmd.Parameters.AddWithValue("@CreatedAt", storage.CreatedAt);
                cmd.Parameters.AddWithValue("@Status", storage.Status);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting storage: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // read
        public List<StorageDTO> GetAllStorage()
        {
            string query = "SELECT * FROM storage";
            List<StorageDTO> storageList = new List<StorageDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    StorageDTO storage = new StorageDTO
                    {
                        StorageId = reader["StorageId"].ToString(),
                        ImportBillDetailId = reader["ImportBillDetailId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = int.Parse(reader["Quantity"].ToString()),
                        Price = double.Parse(reader["Price"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                        CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString()),
                        Status = reader["Status"].ToString() == "active" ? StorageDTO.Option.active : StorageDTO.Option.inactive
                    };
                    storageList.Add(storage);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving storage: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return storageList;
        }

        public List<StorageDTO> GetStorageListByBillImportId(string importBillDetailId)
        {
            string query = "SELECT * FROM storage WHERE ImportBillDetailId = @ImportBillDetailId";
            List<StorageDTO> storageList = new List<StorageDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillDetailId", importBillDetailId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    storageList.Add(new StorageDTO
                    {
                        StorageId = reader["StorageId"].ToString(),
                        ImportBillDetailId = reader["ImportBillDetailId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = int.Parse(reader["Quantity"].ToString()),
                        Price = double.Parse(reader["Price"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                        CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString()),
                        Status = reader["Status"].ToString() == "active" ? StorageDTO.Option.active : StorageDTO.Option.inactive
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving storage by ImportBillDetailId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return storageList;
        }

        public List<StorageDTO> GetStorageListByProductId(string productId)
        {
            string query = "SELECT * FROM storage WHERE ProductId = @ProductId";
            List<StorageDTO> storageList = new List<StorageDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    storageList.Add(new StorageDTO
                    {
                        StorageId = reader["StorageId"].ToString(),
                        ImportBillDetailId = reader["ImportBillDetailId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = int.Parse(reader["Quantity"].ToString()),
                        Price = double.Parse(reader["Price"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                        CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString()),
                        Status = reader["Status"].ToString() == "active" ? StorageDTO.Option.active : StorageDTO.Option.inactive
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving storage by ProductId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return storageList;
        }

        public StorageDTO GetStorageListByStorageId(string storageId)
        {
            string query = "SELECT * FROM storage WHERE StorageId = @StorageId";
            StorageDTO storage = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@StorageId", storageId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    storage = new StorageDTO
                    {
                        StorageId = reader["StorageId"].ToString(),
                        ImportBillDetailId = reader["ImportBillDetailId"].ToString(),
                        ProductId = reader["ProductId"].ToString(),
                        Quantity = int.Parse(reader["Quantity"].ToString()),
                        Price = double.Parse(reader["Price"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                        CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString()),
                        Status = reader["Status"].ToString() == "active" ? StorageDTO.Option.active : StorageDTO.Option.inactive
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving storage by StorageId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return storage;
        }

        // update
        public bool UpdateStorage(StorageDTO storage)
        {
            string query = "UPDATE storage SET Quantity = @Quantity, Price = @Price, TotalPrice = @TotalPrice, Status = @Status WHERE StorageId = @StorageId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Quantity", storage.Quantity);
                cmd.Parameters.AddWithValue("@Price", storage.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", storage.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", storage.Status);
                cmd.Parameters.AddWithValue("@StorageId", storage.StorageId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating storage: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // delete
        public bool DeleteStorage(string storageId)
        {
            string query = "DELETE FROM storage WHERE StorageId = @StorageId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@StorageId", storageId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting storage: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
    }
}
