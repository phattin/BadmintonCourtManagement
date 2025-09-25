using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BillBookingDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy bill booking theo Id
        public BillBookingDTO GetById(string id)
        {
            string query = "SELECT * FROM BillBooking WHERE Id = @Id";
            BillBookingDTO bill = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bill = new BillBookingDTO()
                    {
                        Id = reader["Id"].ToString(),
                        BookingId = reader["BookingId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                        PrePaid = Convert.ToDouble(reader["PrePaid"])
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return bill;
        }

        // Lấy tất cả bill booking
        public List<BillBookingDTO> GetAll()
        {
            string query = "SELECT * FROM BillBooking";
            List<BillBookingDTO> list = new List<BillBookingDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BillBookingDTO()
                    {
                        Id = reader["Id"].ToString(),
                        BookingId = reader["BookingId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                        PrePaid = Convert.ToDouble(reader["PrePaid"])
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

        // Thêm bill booking mới
        public bool Insert(BillBookingDTO bill)
        {
            string query = @"INSERT INTO BillBooking (Id, BookingId, TotalPrice, EmployeeId, CustomerId, DateCreated, PrePaid) 
                             VALUES (@Id, @BookingId, @TotalPrice, @EmployeeId, @CustomerId, @DateCreated, @PrePaid)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", bill.Id);
                cmd.Parameters.AddWithValue("@BookingId", bill.BookingId);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@CustomerId", bill.CustomerId);
                cmd.Parameters.AddWithValue("@DateCreated", bill.DateCreated);
                cmd.Parameters.AddWithValue("@PrePaid", bill.PrePaid);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật bill booking
        public bool Update(BillBookingDTO bill)
        {
            string query = @"UPDATE BillBooking 
                             SET BookingId=@BookingId, TotalPrice=@TotalPrice, EmployeeId=@EmployeeId, 
                                 CustomerId=@CustomerId, DateCreated=@DateCreated, PrePaid=@PrePaid 
                             WHERE Id=@Id";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", bill.Id);
                cmd.Parameters.AddWithValue("@BookingId", bill.BookingId);
                cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@EmployeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@CustomerId", bill.CustomerId);
                cmd.Parameters.AddWithValue("@DateCreated", bill.DateCreated);
                cmd.Parameters.AddWithValue("@PrePaid", bill.PrePaid);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa bill booking
        public bool Delete(string id)
        {
            string query = "DELETE FROM BillBooking WHERE Id=@Id";
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
