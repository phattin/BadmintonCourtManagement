using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class TypeProductDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy tất cả loại sản phẩm chưa xóa
        public List<TypeProductDTO> GetAllTypeProduct()
        {
            string query = "SELECT * FROM typeproduct ";
            List<TypeProductDTO> list = new List<TypeProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new TypeProductDTO()
                    {
                        TypeProductId = reader["TypeId"].ToString(),
                        TypeProductName = reader["TypeName"].ToString()
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

        // Lấy loại sản phẩm theo ID
        public TypeProductDTO GetById(string typeId)
        {
            string query = "SELECT * FROM typeproduct WHERE TypeId = @TypeId";
            TypeProductDTO typeProduct = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@TypeId", typeId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    typeProduct = new TypeProductDTO()
                    {
                        TypeProductId = reader["TypeId"].ToString(),
                        TypeProductName = reader["TypeName"].ToString()
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return typeProduct;
        }

        // Lấy loại sản phẩm theo tên
       public List<TypeProductDTO> GetByTypeName(string typeName)
        {
            string query = "SELECT * FROM typeproduct WHERE TypeName LIKE @TypeName";
            List<TypeProductDTO> list = new List<TypeProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@TypeName", "%" + typeName + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new TypeProductDTO()
                    {
                        TypeProductId = reader["TypeId"].ToString(),
                        TypeProductName = reader["TypeName"].ToString()
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
        // Thêm loại sản phẩm
        public bool InsertTypeProduct(TypeProductDTO typeProduct)
        {
            string query = "INSERT INTO typeproduct (TypeId, TypeName) VALUES (@TypeId, @TypeName)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@TypeId", typeProduct.TypeProductId);
                cmd.Parameters.AddWithValue("@TypeName", typeProduct.TypeProductName);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật loại sản phẩm
        public bool UpdateTypeProduct(TypeProductDTO typeProduct)
        {
            string query = "UPDATE typeproduct SET TypeName=@TypeName WHERE TypeId=@TypeId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@TypeId", typeProduct.TypeProductId);
                cmd.Parameters.AddWithValue("@TypeName", typeProduct.TypeProductName);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa loại sản phẩm
        public bool DeleteTypeProduct(string typeId)
        {
            string query = "DELETE FROM typeproduct WHERE TypeId=@TypeId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@TypeId", typeId);
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