using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BookingDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy booking theo Id
        public BookingDTO GetById(string id)
        {
            string query = "SELECT * FROM booking WHERE Id=@Id";
            BookingDTO booking = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    booking = new BookingDTO(
                        reader["Id"].ToString(),
                        reader["CourtId"].ToString(),
                        Convert.ToBoolean(reader["Status"]),
                        Convert.ToDateTime(reader["StartTime"]),
                        Convert.ToDateTime(reader["EndTime"])
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return booking;
        }

        // Lấy tất cả booking
        public List<BookingDTO> GetAll()
        {
            string query = "SELECT * FROM booking";
            List<BookingDTO> list = new List<BookingDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BookingDTO(
                        reader["Id"].ToString(),
                        reader["CourtId"].ToString(),
                        Convert.ToBoolean(reader["Status"]),
                        Convert.ToDateTime(reader["StartTime"]),
                        Convert.ToDateTime(reader["EndTime"])
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

        // Thêm booking mới
        public bool Insert(BookingDTO booking)
        {
            string query = @"INSERT INTO booking (Id, CourtId, Status, StartTime, EndTime) 
                             VALUES (@Id, @CourtId, @Status, @StartTime, @EndTime)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", booking.Id);
                cmd.Parameters.AddWithValue("@CourtId", booking.CourtId);
                cmd.Parameters.AddWithValue("@Status", booking.Status);
                cmd.Parameters.AddWithValue("@StartTime", booking.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", booking.EndTime);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật booking
        public bool Update(BookingDTO booking)
        {
            string query = @"UPDATE booking 
                             SET CourtId=@CourtId, Status=@Status, StartTime=@StartTime, EndTime=@EndTime 
                             WHERE Id=@Id";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", booking.Id);
                cmd.Parameters.AddWithValue("@CourtId", booking.CourtId);
                cmd.Parameters.AddWithValue("@Status", booking.Status);
                cmd.Parameters.AddWithValue("@StartTime", booking.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", booking.EndTime);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa booking
        public bool Delete(string id)
        {
            string query = "DELETE FROM booking WHERE Id=@Id";
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
