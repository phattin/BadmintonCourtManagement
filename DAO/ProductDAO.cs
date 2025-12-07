using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;
using Mysqlx;
using System.Data.SqlTypes;

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
                        ProductId = reader["ProductId"]?.ToString() ?? string.Empty,
                        ProductName = reader["ProductName"]?.ToString() ?? string.Empty,
                        SupplierId = reader["SupplierId"]?.ToString() ?? string.Empty,
                        ProductImg = reader["ProductImg"]?.ToString() ?? "DefaultProductImage.jpg",
                        Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0,
                        BrandId = reader["BrandId"]?.ToString() ?? string.Empty,
                        TypeId = reader["TypeId"]?.ToString() ?? string.Empty,
                        IsDeleted = reader["IsDeleted"] != DBNull.Value ? Convert.ToInt32(reader["IsDeleted"]) : 0
                    });
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi truy vấn CSDL: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        public List<ProductDTO> GetProductByIds(string brandIds, string typeIds, bool onlyStock)
        {
            var whereClauses = new List<string> { "IsDeleted = 0" };
	    if (onlyStock) {
		    whereClauses.Add($"Quantity > 0");
	    }
            if (brandIds != "")
            {
                whereClauses.Add($"BrandId in ({brandIds})");
            }
            if (typeIds != "")
            {
                whereClauses.Add($"TypeId in ({typeIds})");
            }
            string query = $"SELECT * FROM product WHERE {string.Join(" AND ", whereClauses)}";
            List<ProductDTO> list = new List<ProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                // cmd.Parameters.AddWithValue("@BrandIds", brandIds);
                // cmd.Parameters.AddWithValue("@TypeIds", typeIds);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ProductDTO()
                    {
                        ProductId = reader["ProductId"]?.ToString() ?? string.Empty,
                        ProductName = reader["ProductName"]?.ToString() ?? string.Empty,
                        SupplierId = reader["SupplierId"]?.ToString() ?? string.Empty,
                        ProductImg = reader["ProductImg"]?.ToString() ?? "DefaultProductImage.jpg",
                        Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0,
                        BrandId = reader["BrandId"]?.ToString() ?? string.Empty,
                        TypeId = reader["TypeId"]?.ToString() ?? string.Empty,
                        IsDeleted = reader["IsDeleted"] != DBNull.Value ? Convert.ToInt32(reader["IsDeleted"]) : 0
                    });
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi truy vấn CSDL: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
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
            string query = "INSERT INTO product (ProductId, ProductName, SupplierId, ProductImg, Quantity, BrandId, TypeId, IsDeleted) " +
                           "VALUES (@ProductId, @ProductName, @SupplierId, @ProductImg, @Quantity, @BrandId, @TypeId, 0)";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@SupplierId", product.SupplierId);
                cmd.Parameters.AddWithValue("@ProductImg", product.ProductImg);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@BrandId", product.BrandId);
                cmd.Parameters.AddWithValue("@TypeId", product.TypeId);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi truy vấn CSDL: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // update
        public bool UpdateProduct(ProductDTO product)
        {
            string query = "UPDATE product SET ProductName = @ProductName, Quantity = @Quantity, SupplierId = @SupplierId, " +
                           "BrandId = @BrandId, TypeId = @TypeId, ProductImg = @ProductImg WHERE ProductId = @ProductId AND IsDeleted = 0";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@SupplierId", product.SupplierId);
                cmd.Parameters.AddWithValue("@ProductImg", product.ProductImg);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@BrandId", product.BrandId);
                cmd.Parameters.AddWithValue("@TypeId", product.TypeId);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi truy vấn CSDL: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
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
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi truy vấn CSDL: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
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
                        ProductId = reader["ProductId"]?.ToString() ?? string.Empty,
                        ProductName = reader["ProductName"]?.ToString() ?? string.Empty,
                        SupplierId = reader["SupplierId"]?.ToString() ?? string.Empty,
                        ProductImg = reader["ProductImg"]?.ToString() ?? "DefaultProductImage.jpg",
                        Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0,  // FIXED
                        BrandId = reader["BrandId"]?.ToString() ?? string.Empty,
                        TypeId = reader["TypeId"]?.ToString() ?? string.Empty,
                        IsDeleted = reader["IsDeleted"] != DBNull.Value ? Convert.ToInt32(reader["IsDeleted"]) : 0  // FIXED
                   };
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi truy vấn CSDL: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            finally
            {
                db.CloseConnection();
            }
            return product;
        }

        public List<ProductDTO> GetProductByName(string productName)
        {
            string query = "SELECT * FROM product WHERE ProductName LIKE @ProductName AND IsDeleted = 0";
            List<ProductDTO> productList = new List<ProductDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductName", "%" + productName + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productList.Add(new ProductDTO
                    {
                        ProductId = reader["ProductId"]?.ToString() ?? string.Empty,
                        ProductName = reader["ProductName"]?.ToString() ?? string.Empty,
                        SupplierId = reader["SupplierId"]?.ToString() ?? string.Empty,
                        ProductImg = reader["ProductImg"]?.ToString() ?? "DefaultProductImage.jpg",
                        Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0,  // FIXED
                        BrandId = reader["BrandId"]?.ToString() ?? string.Empty,
                        TypeId = reader["TypeId"]?.ToString() ?? string.Empty,
                        IsDeleted = reader["IsDeleted"] != DBNull.Value ? Convert.ToInt32(reader["IsDeleted"]) : 0  // FIXED
                    });
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi truy vấn CSDL: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Error in ProductDAO\n" + ex);
            }

            finally
            {
                db.CloseConnection();
            }
            return productList;
        }
        public bool HasTransactions(string productId)
        {
            // Kiểm tra xem sản phẩm này có từng xuất hiện trong hóa đơn bán hàng chưa
            string query = "SELECT COUNT(*) FROM billproductdetail WHERE ProductId = @ProductId";
            
            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi truy vấn CSDL: " + ex.Message);
                throw new Exception("Lỗi kiểm tra giao dịch sản phẩm trong CSDL", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                throw new Exception("Lỗi không xác định khi kiểm tra giao dịch sản phẩm", ex);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool DatabaseDeleteProduct(string productId)
        {
            // Kiểm tra xem sản phẩm có trong hóa đơn chưa
            if (HasTransactions(productId))
            {
                throw new InvalidOperationException("Không thể xóa sản phẩm vì sản phẩm đã có trong hóa đơn bán hàng.");
            }

            string query = "DELETE FROM product WHERE ProductId = @ProductId";

            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi xóa sản phẩm: " + ex.Message);
                // Nếu lỗi khóa ngoại thì báo rõ hơn
                if (ex.Number == 1451) // MySQL error code for foreign key constraint
                {
                    throw new InvalidOperationException("Không thể xóa sản phẩm vì đã được sử dụng trong hóa đơn hoặc dữ liệu liên quan.", ex);
                }
                throw new Exception("Lỗi cơ sở dữ liệu khi xóa sản phẩm", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi hệ thống khi xóa sản phẩm", ex);
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public string GenerateNextProductId()  // đổi thành public
        {
            const string prefix = "PD";
            const int digits = 5;

            string query = "SELECT ProductId FROM product WHERE ProductId LIKE 'PD%' ORDER BY CAST(SUBSTRING(ProductId, 3) AS UNSIGNED) DESC LIMIT 1";

            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                        return prefix + "00001";

                    string lastId = result.ToString();
                    if (lastId.StartsWith(prefix) && int.TryParse(lastId.Substring(prefix.Length), out int num))
                    {
                        return prefix + (num + 1).ToString($"D{digits}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo mã sản phẩm tự động", ex);
            }
            finally
            {
                db.CloseConnection();
            }

            return prefix + "00001";
        }


    }
}
