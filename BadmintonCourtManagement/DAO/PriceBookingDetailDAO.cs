using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PriceBookingDetailDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy 1 PriceBookingDetail theo PriceRuleId + BillBookingId
        public PriceBookingDetailDTO GetById(string priceRuleId, string billBookingId)
        {
            string query = "SELECT * FROM price_booking_detail WHERE PriceRuleId=@PriceRuleId AND BillBookingId=@BillBookingId AND IsDeleted=0";
            PriceBookingDetailDTO detail = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PriceRuleId", priceRuleId);
                cmd.Parameters.AddWithValue("@BillBookingId", billBookingId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    detail = new PriceBookingDetailDTO(
                        reader["PriceRuleId"].ToString(),
                        reader["PriceRuleId"].ToString(),
                        reader["BillBookingId"].ToString(),
                        Convert.ToDouble(reader["Price"])
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return detail;
        }

        // Lấy tất cả PriceBookingDetail
        public List<PriceBookingDetailDTO> GetAll()
        {
            string query = "SELECT * FROM price_booking_detail WHERE IsDeleted=0";
            List<PriceBookingDetailDTO> list = new List<PriceBookingDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PriceBookingDetailDTO(
                        reader["PriceRuleId"].ToString(),
                        reader["PriceRuleId"].ToString(),
                        reader["BillBookingId"].ToString(),
                        Convert.ToDouble(reader["Price"])
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

        // Thêm PriceBookingDetail
        public bool Insert(PriceBookingDetailDTO detail)
        {
            string query = "INSERT INTO price_booking_detail (PriceRuleId, BillBookingId, Price, IsDeleted) " +
                           "VALUES (@PriceRuleId, @BillBookingId, @Price, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PriceRuleId", detail.PriceRuleId);
                cmd.Parameters.AddWithValue("@BillBookingId", detail.BillBookingId);
                cmd.Parameters.AddWithValue("@Price", detail.Price);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật PriceBookingDetail
        public bool Update(PriceBookingDetailDTO detail)
        {
            string query = "UPDATE price_booking_detail SET Price=@Price " +
                           "WHERE PriceRuleId=@PriceRuleId AND BillBookingId=@BillBookingId AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PriceRuleId", detail.PriceRuleId);
                cmd.Parameters.AddWithValue("@BillBookingId", detail.BillBookingId);
                cmd.Parameters.AddWithValue("@Price", detail.Price);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm PriceBookingDetail
        public bool Delete(string priceRuleId, string billBookingId)
        {
            string query = "UPDATE price_booking_detail SET IsDeleted=1 WHERE PriceRuleId=@PriceRuleId AND BillBookingId=@BillBookingId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PriceRuleId", priceRuleId);
                cmd.Parameters.AddWithValue("@BillBookingId", billBookingId);
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
