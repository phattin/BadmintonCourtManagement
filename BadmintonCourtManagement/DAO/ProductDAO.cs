using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class ProductDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy tất cả sản phẩm chưa xóa
        public List<ProductDTO> GetAllProducts()
        {
            string query = "SELECT * FROM product WHERE IsDeleted = 0";
            List<ProductDTO> list = new List<ProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ProductDTO()
                    {
                        ProductId = reader["ProductId"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        Producing = reader["Producing"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        BrandId = reader["BrandId"].ToString(),
                        TypeId = reader["TypeId"].ToString(),
                        IDeleted = Convert.ToInt32(reader["IsDeleted"])
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

        // Thêm sản phẩm mới
        public bool InsertProduct(ProductDTO product)
        {
            string query = "INSERT INTO product (ProductId, ProductName, Producing, Quantity, BrandId, TypeId, IsDeleted) " +
                           "VALUES (@ProductId, @ProductName, @Producing, @Quantity, @BrandId, @TypeId, 0)";
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
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // update
        public bool UpdateProduct(ProductDTO product)
        {
            string query = "UPDATE product SET ProductName = @ProductName, Producing = @Producing, Quantity = @Quantity, " +
                           "BrandId = @BrandId, TypeId = @TypeId WHERE ProductId = @ProductId AND IsDeleted = 0";
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
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // Xóa sản phẩm (cập nhật IsDeleted)
        public bool DeleteProduct(string productId)
        {
            string query = "UPDATE product SET IsDeleted = 1 WHERE ProductId = @ProductId ";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // get by id
        public ProductDTO GetProductById(string productId)
        {
            string query = "SELECT * FROM product WHERE ProductId = @ProductId AND IsDeleted = 0";
            ProductDTO product = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    product = new ProductDTO()
                    {
                        ProductId = reader["ProductId"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        Producing = reader["Producing"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        BrandId = reader["BrandId"].ToString(),
                        TypeId = reader["TypeId"].ToString(),
                        IDeleted = Convert.ToInt32(reader["IsDeleted"])
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return product;
        }
    }
}