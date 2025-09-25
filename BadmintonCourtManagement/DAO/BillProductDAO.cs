using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BillProductDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy hóa đơn theo BillProductId
        public BillProductDTO GetById(string billProductId)
        {
            string query = "SELECT * FROM bill_product WHERE BillProductId = @BillProductId";
            BillProductDTO bill = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", billProductId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bill = new BillProductDTO(
                        reader["BillProductId"].ToString(),
                        reader["EmployeeId"].ToString(),
                        reader["CustomerId"].ToString(),
                        Convert.ToInt32(reader["TotalPrice"]),
                        reader["Status"].ToString()
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

        // Lấy tất cả hóa đơn
        public List<BillProductDTO> GetAll()
        {
            string query = "SELECT * FROM bill_product";
            List<BillProductDTO> list = new List<BillProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillProductDTO(
                        reader["BillProductId"].ToString(),
                        reader["EmployeeId"].ToString(),
                        reader["CustomerId"].ToString(),
                        Convert.ToInt32(reader["TotalPrice"]),
                        reader["Status"].ToString()
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

        // Thêm hóa đơn mới
        public bool Insert(BillProductDTO bill)
        {
            string query = @"INSERT INTO bill_product 
                            (BillProductId, EmployeeId, CustomerId, TotalPrice, Status) 
                            VALUES (@BillProductId, @EmployeeId, @CustomerId, @TotalPrice, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", bill.BillProductId);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@CustomerId", bill.CustomerId);
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

        // Cập nhật hóa đơn
        public bool Update(BillProductDTO bill)
        {
            string query = @"UPDATE bill_product 
                            SET EmployeeId=@EmployeeId, CustomerId=@CustomerId, 
                                TotalPrice=@TotalPrice, Status=@Status 
                            WHERE BillProductId=@BillProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", bill.BillProductId);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@CustomerId", bill.CustomerId);
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

        // Xóa hóa đơn
        public bool Delete(string billProductId)
        {
            string query = "DELETE FROM bill_product WHERE BillProductId=@BillProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", billProductId);
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
