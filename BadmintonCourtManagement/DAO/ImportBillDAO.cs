using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class ImportBillDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy tất cả hóa đơn nhập
        public List<ImportBillDTO> GetAll()
        {
            string query = "SELECT * FROM import_bill";
            List<ImportBillDTO> list = new List<ImportBillDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var status = Enum.TryParse(reader["Status"].ToString(), out ImportBillDTO.Option parsedStatus)
                        ? parsedStatus
                        : ImportBillDTO.Option.Unpaid;

                    list.Add(new ImportBillDTO(
                        reader["ImportBillId"].ToString(),
                        reader["SupplierId"].ToString(),
                        reader["EmployeeId"].ToString(),
                        Convert.ToDateTime(reader["DateCreated"]),
                        Convert.ToDouble(reader["TotalPrice"]),
                        status
                    ));
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        // Lấy hóa đơn nhập theo Id
        public ImportBillDTO GetById(string id)
        {
            string query = "SELECT * FROM import_bill WHERE ImportBillId=@Id";
            ImportBillDTO bill = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var status = Enum.TryParse(reader["Status"].ToString(), out ImportBillDTO.Option parsedStatus)
                        ? parsedStatus
                        : ImportBillDTO.Option.Unpaid;

                    bill = new ImportBillDTO(
                        reader["ImportBillId"].ToString(),
                        reader["SupplierId"].ToString(),
                        reader["EmployeeId"].ToString(),
                        Convert.ToDateTime(reader["DateCreated"]),
                        Convert.ToDouble(reader["TotalPrice"]),
                        status
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return bill;
        }

        // Thêm hóa đơn nhập
        public bool Insert(ImportBillDTO bill)
        {
            string query = @"INSERT INTO import_bill 
                            (ImportBillId, SupplierId, EmployeeId, DateCreated, TotalPrice, Status) 
                            VALUES (@Id, @SupplierId, @EmployeeId, @DateCreated, @TotalPrice, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", bill.Id);
                cmd.Parameters.AddWithValue("@SupplierId", bill.SupplierId);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@DateCreated", bill.DateCreated);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", bill.Status.ToString());
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật hóa đơn nhập
        public bool Update(ImportBillDTO bill)
        {
            string query = @"UPDATE import_bill 
                             SET SupplierId=@SupplierId, EmployeeId=@EmployeeId, DateCreated=@DateCreated, 
                                 TotalPrice=@TotalPrice, Status=@Status
                             WHERE ImportBillId=@Id";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", bill.Id);
                cmd.Parameters.AddWithValue("@SupplierId", bill.SupplierId);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@DateCreated", bill.DateCreated);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", bill.Status.ToString());
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa hóa đơn nhập
        public bool Delete(string id)
        {
            string query = "DELETE FROM import_bill WHERE ImportBillId=@Id";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
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
