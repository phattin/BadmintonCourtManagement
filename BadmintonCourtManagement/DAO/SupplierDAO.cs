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
            string query = "SELECT * FROM supplier WHERE SupplierId = @SupplierId AND IsDeleted = 0";
            SupplierDTO supplier = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@SupplierId", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    supplier = new SupplierDTO()
                    {
                        SupplierId = reader["SupplierId"].ToString(),
                        SupplierName = reader["SupplierName"].ToString(),
                        SupplierAddress = reader["Address"].ToString(),
                        SupplierEmail = reader["Email"].ToString(),
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
                        SupplierId = reader["SupplierId"].ToString(),
                        SupplierName = reader["SupplierName"].ToString(),
                        SupplierAddress = reader["Address"].ToString(),
                        SupplierEmail = reader["Email"].ToString(),
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
            string query = "SELECT * FROM supplier WHERE (SupplierName LIKE @Keyword OR Address LIKE @Keyword OR Email LIKE @Keyword) AND IsDeleted = 0";
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
                        SupplierId = reader["SipplierId"].ToString(),
                        SupplierName = reader["Suppliername"].ToString(),
                        SupplierAddress = reader["Address"].ToString(),
                        SupplierEmail = reader["Email"].ToString(),
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
            string query = "INSERT INTO supplier (SupplierName, Address, Email, IsDeleted) VALUES (@SupplierName, @Address, @Email, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@Address", supplier.SupplierAddress);
                cmd.Parameters.AddWithValue("@Email", supplier.SupplierEmail);
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
            string query = "UPDATE supplier SET SupplierName=@SuplierName, Address=@Address, Email=@Email WHERE SupplierId=@SupplerId AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@Address", supplier.SupplierAddress);
                cmd.Parameters.AddWithValue("@Email", supplier.SupplierEmail);
                cmd.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
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
                cmd.Parameters.AddWithValue("@SupplierId", id);
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