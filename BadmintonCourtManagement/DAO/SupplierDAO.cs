using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class SupplierDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy nhà cung cấp theo ID
        public SupplierDTO GetById(string id)
        {
            string query = "SELECT * FROM supplier WHERE Id = @Id AND IsDeleted = 0";
            SupplierDTO supplier = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    supplier = new SupplierDTO()
                    {
                        Id = reader["Id"].ToString(),
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        IsDeleted = Convert.ToInt32(reader["IsDeleted"])
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return supplier;
        }

        // Lấy tất cả nhà cung cấp chưa xóa
        public List<SupplierDTO> GetAllSuppliers()
        {
            string query = "SELECT * FROM supplier WHERE IsDeleted = 0";
            List<SupplierDTO> list = new List<SupplierDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SupplierDTO()
                    {
                        Id = reader["Id"].ToString(),
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        IsDeleted = Convert.ToInt32(reader["IsDeleted"])
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

        // Search
        public List<SupplierDTO> Search(string keyword)
        {
            string query = "SELECT * FROM supplier WHERE (Name LIKE @Keyword OR Address LIKE @Keyword OR Phone LIKE @Keyword) AND IsDeleted = 0";
            List<SupplierDTO> list = new List<SupplierDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SupplierDTO()
                    {
                        Id = reader["Id"].ToString(),
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        IsDeleted = Convert.ToInt32(reader["IsDeleted"])
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

        // Insert
        public bool InsertSupplier(SupplierDTO supplier)
        {
            string query = "INSERT INTO supplier (Name, Address, Phone, IsDeleted) VALUES (@Name, @Address, @Phone, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Name", supplier.Name);
                cmd.Parameters.AddWithValue("@Address", supplier.Address);
                cmd.Parameters.AddWithValue("@Phone", supplier.Phone);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // update
        public bool UpdateSupplier(SupplierDTO supplier)
        {
            string query = "UPDATE supplier SET Name=@Name, Address=@Address, Phone=@Phone WHERE Id=@Id AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Name", supplier.Name);
                cmd.Parameters.AddWithValue("@Address", supplier.Address);
                cmd.Parameters.AddWithValue("@Phone", supplier.Phone);
                cmd.Parameters.AddWithValue("@Id", supplier.Id);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // delete
        public bool DeleteSupplier(string id)
        {
            string query = "UPDATE supplier SET IsDeleted=1 WHERE Id=@Id AND IsDeleted=0";
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