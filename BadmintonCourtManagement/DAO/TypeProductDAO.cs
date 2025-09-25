using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class TypeProductDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy TypeProduct theo Id
        public TypeProductDTO GetById(string id)
        {
            string query = "SELECT * FROM typeproduct WHERE Id=@Id AND IsDeleted=0";
            TypeProductDTO typeProduct = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    typeProduct = new TypeProductDTO(
                        reader["Id"].ToString(),
                        reader["Name"].ToString()
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return typeProduct;
        }

        // Lấy tất cả TypeProduct chưa bị xóa
        public List<TypeProductDTO> GetAll()
        {
            string query = "SELECT * FROM typeproduct WHERE IsDeleted=0";
            List<TypeProductDTO> list = new List<TypeProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new TypeProductDTO(
                        reader["Id"].ToString(),
                        reader["Name"].ToString()
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

        // Thêm TypeProduct
        public bool Insert(TypeProductDTO typeProduct)
        {
            string query = "INSERT INTO typeproduct (Id, Name, IsDeleted) VALUES (@Id, @Name, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", typeProduct.Id);
                cmd.Parameters.AddWithValue("@Name", typeProduct.Name);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật TypeProduct
        public bool Update(TypeProductDTO typeProduct)
        {
            string query = "UPDATE typeproduct SET Name=@Name WHERE Id=@Id AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", typeProduct.Id);
                cmd.Parameters.AddWithValue("@Name", typeProduct.Name);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm TypeProduct
        public bool Delete(string id)
        {
            string query = "UPDATE typeproduct SET IsDeleted=1 WHERE Id=@Id";
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
