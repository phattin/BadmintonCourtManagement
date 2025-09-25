using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BillProductDetailDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy chi tiết hóa đơn theo BillProductId
        public List<BillProductDetailDTO> GetByBillProductId(string billProductId)
        {
            string query = "SELECT * FROM bill_product_detail WHERE BillProductId = @BillProductId";
            List<BillProductDetailDTO> list = new List<BillProductDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", billProductId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillProductDetailDTO(
                        reader["BillProductId"].ToString(),
                        reader["ProductId"].ToString(),
                        Convert.ToInt32(reader["Quantity"]),
                        Convert.ToInt32(reader["Price"]),
                        Convert.ToInt32(reader["TotalPrice"])
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

        // Lấy tất cả chi tiết hóa đơn
        public List<BillProductDetailDTO> GetAll()
        {
            string query = "SELECT * FROM bill_product_detail";
            List<BillProductDetailDTO> list = new List<BillProductDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillProductDetailDTO(
                        reader["BillProductId"].ToString(),
                        reader["ProductId"].ToString(),
                        Convert.ToInt32(reader["Quantity"]),
                        Convert.ToInt32(reader["Price"]),
                        Convert.ToInt32(reader["TotalPrice"])
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

        // Thêm chi tiết hóa đơn
        public bool Insert(BillProductDetailDTO detail)
        {
            string query = @"INSERT INTO bill_product_detail 
                            (BillProductId, ProductId, Quantity, Price, TotalPrice) 
                            VALUES (@BillProductId, @ProductId, @Quantity, @Price, @TotalPrice)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", detail.BillProductId);
                cmd.Parameters.AddWithValue("@ProductId", detail.ProductId);
                cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                cmd.Parameters.AddWithValue("@Price", detail.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", detail.TotalPrice);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật chi tiết hóa đơn
        public bool Update(BillProductDetailDTO detail)
        {
            string query = @"UPDATE bill_product_detail 
                            SET Quantity=@Quantity, Price=@Price, TotalPrice=@TotalPrice 
                            WHERE BillProductId=@BillProductId AND ProductId=@ProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", detail.BillProductId);
                cmd.Parameters.AddWithValue("@ProductId", detail.ProductId);
                cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                cmd.Parameters.AddWithValue("@Price", detail.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", detail.TotalPrice);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa chi tiết hóa đơn (theo BillProductId + ProductId)
        public bool Delete(string billProductId, string productId)
        {
            string query = "DELETE FROM bill_product_detail WHERE BillProductId=@BillProductId AND ProductId=@ProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", billProductId);
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
