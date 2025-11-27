using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;
using System.Data;

namespace BadmintonCourtManagement.DAO
{
    public class BillImportDAO
    {
        private DBConnection db = new DBConnection();

	public string GetMaxId() {
		string query = "SELECT MAX(ImportBillId) FROM ImportBill WHERE ImportBillId LIKE 'IB%'";
		try {
			db.OpenConnection();
			MySqlCommand cmd = new MySqlCommand(query, db.Connection);
			var result = cmd.ExecuteScalar();
			if (result != DBNull.Value && result != null) {
				return result.ToString();
			}
			else {
				return null;
			}
		}
		catch (Exception ex) {
			throw new Exception("Error retrieving max ImportBillId: " + ex.Message);
		} finally {
			db.CloseConnection();
		}
	}

        // create
        public bool InsertImportBill(ImportBillDTO importBill)
        {
            string query = "INSERT INTO ImportBill (ImportBillId, EmployeeId, SupplierId, DateCreated, TotalPrice, Status) VALUES (@ImportBillId, @EmployeeId, @SupplierId, @DateCreated, @TotalPrice, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", importBill.ImportBillId);
                cmd.Parameters.AddWithValue("@EmployeeId", importBill.EmployeeId);
                cmd.Parameters.AddWithValue("@SupplierId", importBill.SupplierId);
                importBill.DateCreated = DateTime.Now;
                cmd.Parameters.AddWithValue("@DateCreated", importBill.DateCreated);
                cmd.Parameters.AddWithValue("@TotalPrice", importBill.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", importBill.Status.ToString());
                result = cmd.ExecuteNonQuery();
            }
            finally {
                db.CloseConnection();
            }
            return result > 0;
        }

        // read
        public List<ImportBillDTO> SearchImportBill(string searchCriteria)
        {
            string query = "SELECT * FROM ImportBill WHERE ImportBillId LIKE @search OR EmployeeId LIKE @search OR SupplierId LIKE @search";
            List<ImportBillDTO> list = new List<ImportBillDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@search", "%" + searchCriteria + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ImportBillDTO()
                    {
                        ImportBillId = reader["ImportBillId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        SupplierId = reader["SupplierId"].ToString(),
                        DateCreated = DateTime.Parse(reader["DateCreated"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                        Status = reader["Status"] != DBNull.Value
                            ? (ImportBillDTO.Option)Enum.Parse(typeof(ImportBillDTO.Option), reader["Status"].ToString())
                            : default(ImportBillDTO.Option),
                    });
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        public List<ImportBillDTO> GetAllImportBills()
        {
            string query = "SELECT * FROM ImportBill";
            List<ImportBillDTO> list = new List<ImportBillDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ImportBillDTO()
                    {
                        ImportBillId = reader["ImportBillId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        SupplierId = reader["SupplierId"].ToString(),
                        DateCreated = DateTime.Parse(reader["DateCreated"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                        Status = reader["Status"] != DBNull.Value
                            ? (ImportBillDTO.Option)Enum.Parse(typeof(ImportBillDTO.Option), reader["Status"].ToString())
                            : default(ImportBillDTO.Option),
                    });
                }
                reader.Close();
            }
            finally {
                db.CloseConnection();
            }
            return list;
        }

        public ImportBillDTO GetImportBillById(string id)
        {
            string query = "SELECT * FROM ImportBill WHERE ImportBillId = @id";
            ImportBillDTO bill;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                bill = new ImportBillDTO()
                {
                    ImportBillId = reader["ImportBillId"].ToString(),
                    EmployeeId = reader["EmployeeId"].ToString(),
                    SupplierId = reader["SupplierId"].ToString(),
                    DateCreated = DateTime.Parse(reader["DateCreated"].ToString()),
                    TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                    Status = reader["Status"] != DBNull.Value
                            ? (ImportBillDTO.Option)Enum.Parse(typeof(ImportBillDTO.Option), reader["Status"].ToString())
                            : default(ImportBillDTO.Option),
                };
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return bill;
        }

        public List<ImportBillDTO> GetImportBillBySupplierId(string supplierId)
        {
            string query = "SELECT * FROM ImportBill WHERE SupplierId = @id";
            List<ImportBillDTO> list = new List<ImportBillDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", supplierId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ImportBillDTO()
                    {
                        ImportBillId = reader["ImportBillId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        SupplierId = reader["SupplierId"].ToString(),
                        DateCreated = DateTime.Parse(reader["DateCreated"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                        Status = reader["Status"] != DBNull.Value
                            ? (ImportBillDTO.Option)Enum.Parse(typeof(ImportBillDTO.Option), reader["Status"].ToString())
                            : default(ImportBillDTO.Option),
                    });
                }
                reader.Close();
            }
            finally {
                db.CloseConnection();
            }
            return list;
        }

        public List<ImportBillDTO> GetImportBillByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT * FROM ImportBill WHERE DateCreated <= @EndDate AND DateCreated >= @StartDate";
            List<ImportBillDTO> list = new List<ImportBillDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ImportBillDTO
                    {
                        ImportBillId = reader["ImportBillId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        SupplierId = reader["SupplierId"].ToString(),
                        DateCreated = DateTime.Parse(reader["DateCreated"].ToString()),
                        TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                        Status = (ImportBillDTO.Option)Enum.Parse(typeof(ImportBillDTO.Option), reader["Status"].ToString())
                    });
                }
                reader.Close();
            }
            finally {
                db.CloseConnection();
            }
            return list;
        }

        // update
        public bool UpdateImportBill(ImportBillDTO bill)
        {
            string query = "UPDATE ImportBill SET SupplierId = @SupplierId, EmployeeId = @EmployeeId, DateCreated = @DateCreated, TotalPrice = @TotalPrice, Status = @Status WHERE ImportBillId = @ImportBillId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", bill.ImportBillId);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@SupplierId", bill.SupplierId);
                cmd.Parameters.AddWithValue("@DateCreated", bill.DateCreated);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", bill.Status);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // delete
        public bool DeleteOneImportBill(string importBillId)
        {
            string query = "DELETE FROM ImportBill WHERE ImportBillId = @ImportBillId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", importBillId);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
    }
}
