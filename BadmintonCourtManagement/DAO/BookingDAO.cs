using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BookingDAO
    {
        private DBConnection db = new DBConnection();

        // create
        public bool InsertBooking(BookingDTO booking)
        {
            string query = "INSERT INTO booking (BookingId, CourtId, Status, StartTime, EndTime)"
            + " VALUES (@BookingId, @CourtId, @Status, @StartTime, @EndTime)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BookingId", booking.BookingId);
                cmd.Parameters.AddWithValue("@CourtId", booking.CourtId);
                cmd.Parameters.AddWithValue("@Status", booking.Status.ToString());
                cmd.Parameters.AddWithValue("@StartTime", booking.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", booking.EndTime);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting booking: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
        // read
        public List<BookingDTO> GetAllBookings()
        {
            string query = "SELECT * FROM booking";
            List<BookingDTO> bookings = new List<BookingDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BookingDTO booking = new BookingDTO
                    {
                        BookingId = reader["BookingId"].ToString(),
                        CourtId = reader["CourtId"].ToString(),
                        Status = reader["Status"] != DBNull.Value
                        ? (BookingDTO.Option)Enum.Parse(typeof(BookingDTO.Option), reader["Status"].ToString())
                        : default(BookingDTO.Option),
                        StartTime = DateTime.Parse(reader["StartTime"].ToString()),
                        EndTime = DateTime.Parse(reader["EndTime"].ToString()),
                    };
                    bookings.Add(booking);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving bookings: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
                return bookings;
        }

        // Get bookings by court ID
        public List<BookingDTO> GetBookingsByCourtId(string courtId)
        {
            string query = "SELECT * FROM booking WHERE CourtId = @CourtId";
            List<BookingDTO> bookings = new List<BookingDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtId", courtId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BookingDTO booking = new BookingDTO
                    {
                        BookingId = reader["BookingId"].ToString(),
                        CourtId = reader["CourtId"].ToString(),
                        Status = reader["Status"] != DBNull.Value
                            ? (BookingDTO.Option)Enum.Parse(typeof(BookingDTO.Option), reader["Status"].ToString())
                            : default(BookingDTO.Option),
                        StartTime = DateTime.Parse(reader["StartTime"].ToString()),
                        EndTime = DateTime.Parse(reader["EndTime"].ToString()),
                    };
                    bookings.Add(booking);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving bookings by court ID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return bookings;
        }

        // // Get bookings by status
        // public List<BookingDTO> GetBookingsByStatus(string status)
        // {
        //     string query = "SELECT * FROM booking WHERE Status = @Status";
        //     List<BookingDTO> bookings = new List<BookingDTO>();
        //     try
        //     {
        //         db.OpenConnection();
        //         MySqlCommand cmd = new MySqlCommand(query, db.Connection);
        //         cmd.Parameters.AddWithValue("@Status", status);
        //         MySqlDataReader reader = cmd.ExecuteReader();
        //         while (reader.Read())
        //         {
        //             BookingDTO booking = new BookingDTO
        //             {
        //                 BookingId = reader["BookingId"].ToString(),
        //                 CourtId = reader["CourtId"].ToString(),
        //                 Status = reader["Status"] != DBNull.Value
        //                     ? (BookingDTO.Option)Enum.Parse(typeof(BookingDTO.Option), reader["Status"].ToString())
        //                     : default(BookingDTO.Option),
        //                 StartTime = DateTime.Parse(reader["StartTime"].ToString()),
        //                 EndTime = DateTime.Parse(reader["EndTime"].ToString()),
        //             };
        //             bookings.Add(booking);
        //         }
        //         reader.Close();
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception("Error retrieving bookings by status: " + ex.Message);
        //     }
        //     finally
        //     {
        //         db.CloseConnection();
        //     }
        //     return bookings;
        // }

        public BookingDTO GetBookingById(string bookingId)
        {
            string query = "SELECT * FROM booking WHERE BookingId = @BookingId";
            BookingDTO booking = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BookingId", bookingId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // ch? ??c 1 dòng duy nh?t
                {
                    booking = new BookingDTO
                    {
                        BookingId = reader["BookingId"].ToString(),
                        CourtId = reader["CourtId"].ToString(),
                        Status = reader["Status"] != DBNull.Value
                            ? (BookingDTO.Option)Enum.Parse(typeof(BookingDTO.Option), reader["Status"].ToString())
                            : default(BookingDTO.Option),
                        StartTime = DateTime.Parse(reader["StartTime"].ToString()),
                        EndTime = DateTime.Parse(reader["EndTime"].ToString()),
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving booking by ID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return booking;
        }

        public List<BookingDTO> Search(string search )
        {
            string query = "SELECT * FROM booking WHERE BookingId LIKE @search OR CourtId LIKE @search OR Status LIKE @search OR StartTime LIKE @search OR EndTime LIKE @search";
            List<BookingDTO> bookings = new List<BookingDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BookingDTO booking = new BookingDTO
                    {
                        BookingId = reader["BookingId"].ToString(),
                        CourtId = reader["CourtId"].ToString(),
                        Status = reader["Status"] != DBNull.Value
                            ? (BookingDTO.Option)Enum.Parse(typeof(BookingDTO.Option), reader["Status"].ToString())
                            : default(BookingDTO.Option),
                        StartTime = DateTime.Parse(reader["StartTime"].ToString()),
                        EndTime = DateTime.Parse(reader["EndTime"].ToString()),
                    };
                    bookings.Add(booking);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching bookings: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return bookings;
        }
        // update
        public bool UpdateBooking(BookingDTO booking)
        {
            string query = "UPDATE booking SET CourtId = @CourtId, Status = @Status, StartTime = @StartTime, EndTime = @EndTime WHERE BookingId = @BookingId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BookingId", booking.BookingId);
                cmd.Parameters.AddWithValue("@CourtId", booking.CourtId);
                cmd.Parameters.AddWithValue("@Status", booking.Status);
                cmd.Parameters.AddWithValue("@StartTime", booking.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", booking.EndTime);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating booking: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
        // delete
        public bool DeleteBooking(string bookingId)
        {
            string query = "DELETE FROM booking WHERE BookingId = @BookingId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BookingId", bookingId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting booking: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
    }
}
