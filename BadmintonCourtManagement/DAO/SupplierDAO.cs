using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class SupplierDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy 1 nhà cung cấp theo Id
        public SupplierDTO GetById(string id)
        {
            string query = "SELECT * FROM supplier WHERE Id=@Id AND IsDeleted=0";
            SupplierDTO supplier = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    supplier = new SupplierDTO(
                        reader["Id"].ToString(),
                        reader["Name"].ToString(),
                        reader["Address"].ToString(),
                        reader["Email"].ToString(),
                        Convert.ToBoolean(reader["IsDeleted"])
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return supplier;
        }

        // Lấy tất cả nhà cung cấp chưa bị xóa
        public List<SupplierDTO> GetAll()
        {
            string query = "SELECT * FROM supplier WHERE IsDeleted=0";
            List<SupplierDTO> list = new List<SupplierDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SupplierDTO(
                        reader["Id"].ToString(),
                        reader["Name"].ToString(),
                        reader["Address"].ToString(),
                        reader["Email"].ToString(),
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

        // Thêm nhà cung cấp mới
        public bool Insert(SupplierDTO supplier)
        {
            string query = "INSERT INTO supplier (Id, Name, Address, Email, IsDeleted) VALUES (@Id, @Name, @Address, @Email, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", supplier.Id);
                cmd.Parameters.AddWithValue("@Name", supplier.Name);
                cmd.Parameters.AddWithValue("@Address", supplier.Address);
                cmd.Parameters.AddWithValue("@Email", supplier.Email);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật thông tin nhà cung cấp
        public bool Update(SupplierDTO supplier)
        {
            string query = "UPDATE supplier SET Name=@Name, Address=@Address, Email=@Email WHERE Id=@Id AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", supplier.Id);
                cmd.Parameters.AddWithValue("@Name", supplier.Name);
                cmd.Parameters.AddWithValue("@Address", supplier.Address);
                cmd.Parameters.AddWithValue("@Email", supplier.Email);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm (IsDeleted=1)
        public bool Delete(string id)
        {
            string query = "UPDATE supplier SET IsDeleted=1 WHERE Id=@Id";
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
