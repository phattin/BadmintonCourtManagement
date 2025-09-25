using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class CustomerDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy tất cả khách hàng (chỉ lấy khách hàng chưa bị xóa)
        public List<CustomerDTO> GetAll()
        {
            string query = "SELECT * FROM customer WHERE IsDeleted = 0";
            List<CustomerDTO> list = new List<CustomerDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new CustomerDTO(
                        reader["CustomerId"].ToString(),
                        reader["CustomerName"].ToString(),
                        reader["Phone"].ToString(),
                        Convert.ToBoolean(reader["IsDeleted"])
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

        // Lấy khách hàng theo Id
        public CustomerDTO GetById(string id)
        {
            string query = "SELECT * FROM customer WHERE CustomerId=@CustomerId";
            CustomerDTO customer = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer = new CustomerDTO(
                        reader["CustomerId"].ToString(),
                        reader["CustomerName"].ToString(),
                        reader["Phone"].ToString(),
                        Convert.ToBoolean(reader["IsDeleted"])
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return customer;
        }

        // Thêm khách hàng mới
        public bool Insert(CustomerDTO customer)
        {
            string query = "INSERT INTO customer (CustomerId, CustomerName, Phone, IsDeleted) VALUES (@CustomerId, @CustomerName, @Phone, @IsDeleted)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", customer.Id);
                cmd.Parameters.AddWithValue("@CustomerName", customer.Name);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@IsDeleted", customer.IsDeleted);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật khách hàng
        public bool Update(CustomerDTO customer)
        {
            string query = "UPDATE customer SET CustomerName=@CustomerName, Phone=@Phone, IsDeleted=@IsDeleted WHERE CustomerId=@CustomerId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", customer.Id);
                cmd.Parameters.AddWithValue("@CustomerName", customer.Name);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@IsDeleted", customer.IsDeleted);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm (đánh dấu IsDeleted = 1)
        public bool SoftDelete(string customerId)
        {
            string query = "UPDATE customer SET IsDeleted=1 WHERE CustomerId=@CustomerId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa cứng (DELETE)
        public bool HardDelete(string customerId)
        {
            string query = "DELETE FROM customer WHERE CustomerId=@CustomerId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
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
