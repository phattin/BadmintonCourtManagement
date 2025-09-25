using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BillImportProductDetailDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy chi tiết phiếu nhập theo ImportBillId
        public List<BillImportProductDetailDTO> GetByImportBillId(string importBillId)
        {
            string query = "SELECT * FROM bill_import_product_detail WHERE ImportBillId = @ImportBillId";
            List<BillImportProductDetailDTO> list = new List<BillImportProductDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", importBillId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillImportProductDetailDTO(
                        reader["ImportBillId"].ToString(),
                        reader["ProductId"].ToString(),
                        Convert.ToInt32(reader["Quantity"]),
                        Convert.ToInt32(reader["Price"]),
                        Convert.ToInt32(reader["TotalPrice"]),
                        reader["Status"].ToString()
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

        // Lấy tất cả chi tiết phiếu nhập
        public List<BillImportProductDetailDTO> GetAll()
        {
            string query = "SELECT * FROM bill_import_product_detail";
            List<BillImportProductDetailDTO> list = new List<BillImportProductDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillImportProductDetailDTO(
                        reader["ImportBillId"].ToString(),
                        reader["ProductId"].ToString(),
                        Convert.ToInt32(reader["Quantity"]),
                        Convert.ToInt32(reader["Price"]),
                        Convert.ToInt32(reader["TotalPrice"]),
                        reader["Status"].ToString()
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

        // Thêm chi tiết phiếu nhập
        public bool Insert(BillImportProductDetailDTO detail)
        {
            string query = @"INSERT INTO bill_import_product_detail 
                            (ImportBillId, ProductId, Quantity, Price, TotalPrice, Status) 
                            VALUES (@ImportBillId, @ProductId, @Quantity, @Price, @TotalPrice, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", detail.ImportBillId);
                cmd.Parameters.AddWithValue("@ProductId", detail.ProductId);
                cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                cmd.Parameters.AddWithValue("@Price", detail.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", detail.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", detail.Status);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật chi tiết phiếu nhập
        public bool Update(BillImportProductDetailDTO detail)
        {
            string query = @"UPDATE bill_import_product_detail 
                            SET Quantity=@Quantity, Price=@Price, TotalPrice=@TotalPrice, Status=@Status 
                            WHERE ImportBillId=@ImportBillId AND ProductId=@ProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", detail.ImportBillId);
                cmd.Parameters.AddWithValue("@ProductId", detail.ProductId);
                cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                cmd.Parameters.AddWithValue("@Price", detail.Price);
                cmd.Parameters.AddWithValue("@TotalPrice", detail.TotalPrice);
                cmd.Parameters.AddWithValue("@Status", detail.Status);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa chi tiết phiếu nhập (theo ImportBillId + ProductId)
        public bool Delete(string importBillId, string productId)
        {
            string query = "DELETE FROM bill_import_product_detail WHERE ImportBillId=@ImportBillId AND ProductId=@ProductId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ImportBillId", importBillId);
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
