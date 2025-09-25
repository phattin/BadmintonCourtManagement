using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class ProductDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy 1 sản phẩm theo ID
        public ProductDTO GetById(string productId)
        {
            string query = "SELECT * FROM product WHERE ProductId=@ProductId AND IsDeleted=0";
            ProductDTO product = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    product = new ProductDTO(
                        reader["ProductId"].ToString(),
                        reader["ProductName"].ToString(),
                        reader["Producing"].ToString(),
                        Convert.ToInt32(reader["Quantity"]),
                        reader["BrandId"].ToString(),
                        reader["TypeId"].ToString(),
                        Convert.ToInt32(reader["IsDeleted"])
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return product;
        }

        // Lấy tất cả sản phẩm
        public List<ProductDTO> GetAll()
        {
            string query = "SELECT * FROM product WHERE IsDeleted=0";
            List<ProductDTO> list = new List<ProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ProductDTO(
                        reader["ProductId"].ToString(),
                        reader["ProductName"].ToString(),
                        reader["Producing"].ToString(),
                        Convert.ToInt32(reader["Quantity"]),
                        reader["BrandId"].ToString(),
                        reader["TypeId"].ToString(),
                        Convert.ToInt32(reader["IsDeleted"])
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

        // Thêm sản phẩm
        public bool Insert(ProductDTO product)
        {
            string query = @"INSERT INTO product 
                            (ProductId, ProductName, Producing, Quantity, BrandId, TypeId, IsDeleted) 
                            VALUES (@ProductId, @ProductName, @Producing, @Quantity, @BrandId, @TypeId, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Producing", product.Producing);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@BrandId", product.BrandId);
                cmd.Parameters.AddWithValue("@TypeId", product.TypeId);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật sản phẩm
        public bool Update(ProductDTO product)
        {
            string query = @"UPDATE product 
                            SET ProductName=@ProductName, Producing=@Producing, Quantity=@Quantity, 
                                BrandId=@BrandId, TypeId=@TypeId
                            WHERE ProductId=@ProductId AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Producing", product.Producing);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@BrandId", product.BrandId);
                cmd.Parameters.AddWithValue("@TypeId", product.TypeId);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm sản phẩm
        public bool Delete(string productId)
        {
            string query = "UPDATE product SET IsDeleted=1 WHERE ProductId=@ProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", productId);
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
