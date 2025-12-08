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

        public List<BookingDTO> GetSuccessfulBookings()
        {
            string query = "SELECT * FROM booking WHERE Status = 'successful'";
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
                throw new Exception("Error retrieving successful bookings: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return bookings;
        }

        public List<BookingDTO> GetSuccessfulBookingsByCourtID (string courtID)
        {
            string query = "SELECT * FROM booking WHERE Status = 'successful' AND CourtId = @CourtId";
            List<BookingDTO> bookings = new List<BookingDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtId", courtID);
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
                throw new Exception("Error retrieving successful bookings by court ID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return bookings;
        }

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

        // 🔹 Lấy BookingId tiếp theo
        public string GetNextBookingId()
        {
            string query = "SELECT BookingId FROM booking ORDER BY BookingId DESC LIMIT 1";
            string nextId = "BK00000001";  // ID đầu tiên

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string lastId = reader["BookingId"].ToString(); // VD: BK00000005

                    if (lastId.StartsWith("BK") && int.TryParse(lastId.Substring(2), out int numericPart))
                    {
                        nextId = "BK" + (numericPart + 1).ToString("D8"); // D8 => 8 chữ số: 00000006
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // log lỗi nếu cần
                return nextId; // vẫn trả về nextId hiện tại
            }
            finally
            {
                db.CloseConnection();
            }

            return nextId;
        }

        public List<BookingDTO> Filter(DateOnly date, TimeOnly startTime, TimeOnly endTime)
        {
            List<BookingDTO> result = new List<BookingDTO>();
            string query = "SELECT * FROM booking";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var booking = new BookingDTO
                    {
                        BookingId = reader["BookingId"].ToString(),
                        CourtId = reader["CourtId"].ToString(),
                        Status = reader["Status"] != DBNull.Value
                            ? (BookingDTO.Option)Enum.Parse(typeof(BookingDTO.Option), reader["Status"].ToString())
                            : default,
                        StartTime = DateTime.Parse(reader["StartTime"].ToString()),
                        EndTime = DateTime.Parse(reader["EndTime"].ToString()),
                    };

                    // Lấy ngày trong DB
                    DateOnly bookingDate = DateOnly.FromDateTime(booking.StartTime);

                    // ❗ Chỉ lấy booking có đúng ngày
                    if (bookingDate != date)
                        continue;

                    // Tách giờ từ DB
                    TimeOnly dbStart = TimeOnly.FromDateTime(booking.StartTime);
                    TimeOnly dbEnd = TimeOnly.FromDateTime(booking.EndTime);

                    bool addBooking = false;

                    // 🟦 Nếu endTime không được chọn → lọc theo startTime
                    if (endTime == default)
                    {
                        if (dbStart >= startTime)
                            addBooking = true;
                    }
                    else
                    {
                        // 🟩 Khoảng thời gian giao nhau
                        if (dbStart < endTime && dbEnd > startTime)
                            addBooking = true;
                    }

                    // 🟥 Nếu startTime nằm trong khoảng DB
                    if (dbStart <= startTime && startTime < dbEnd)
                        addBooking = true;

                    // 🟥 Nếu endTime nằm trong khoảng DB
                    if (endTime != default && dbStart < endTime && endTime <= dbEnd)
                        addBooking = true;

                    if (addBooking)
                    {
                        booking.Status = BookingDTO.Option.playing;
                        result.Add(booking);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error filtering bookings: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return result;
        }



    }
}
