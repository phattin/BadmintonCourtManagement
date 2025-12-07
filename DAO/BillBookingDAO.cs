using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BadmintonCourtManagement.DAO
{
    public class BillBookingDAO
    {
        private DBConnection db;

        public BillBookingDAO()
        {
            db = new DBConnection();
        }

        // 🔹 Lấy danh sách tất cả hóa đơn
        public List<BillBookingDTO> GetAllBillBookings()
        {
            List<BillBookingDTO> list = new List<BillBookingDTO>();
            string query = "SELECT * FROM billbooking";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BillBookingDTO bill = new BillBookingDTO
                    {
                        BillBookingId = reader["BillBookingId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        BookingId = reader["BookingId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        PrePayment = Convert.ToDouble(reader["PrePayment"])
                    };
                    list.Add(bill);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lấy danh sách hóa đơn: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        // 🔹 Lấy hóa đơn theo ID
        public BillBookingDTO GetBillBookingById(string id)
        {
            string query = "SELECT * FROM billbooking WHERE BillBookingId = @id";
            BillBookingDTO bill = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bill = new BillBookingDTO
                    {
                        BillBookingId = reader["BillBookingId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        BookingId = reader["BookingId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        PrePayment = Convert.ToDouble(reader["PrePayment"])
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lấy hóa đơn theo ID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return bill;
        }

        // 🔹 Lấy hóa đơn theo BookingId
        public BillBookingDTO GetBillBookingByBookingId(string bookingId)
        {
            string query = "SELECT * FROM billbooking WHERE BookingId = @bookingId";
            BillBookingDTO bill = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@bookingId", bookingId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bill = new BillBookingDTO
                    {
                        BillBookingId = reader["BillBookingId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        BookingId = reader["BookingId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        PrePayment = Convert.ToDouble(reader["PrePayment"])
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lấy hóa đơn theo BookingId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return bill;
        }

        // 🔹 Thêm hóa đơn mới
        public bool InsertBillBooking(BillBookingDTO bill)
        {
            string query = @"INSERT INTO billbooking 
                            (BillBookingId, EmployeeId, CustomerId, BookingId, TotalPrice, PrePayment) 
                            VALUES (@billBookingId, @employeeId, @customerId, @bookingId, @totalPrice, @prePayment)";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@billBookingId", bill.BillBookingId);
                cmd.Parameters.AddWithValue("@employeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@customerId", bill.CustomerId);
                cmd.Parameters.AddWithValue("@bookingId", bill.BookingId);
                cmd.Parameters.AddWithValue("@totalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@prePayment", bill.PrePayment);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Cập nhật hóa đơn
        public bool UpdateBillBooking(BillBookingDTO bill)
        {
            string query = @"UPDATE billbooking 
                            SET EmployeeId = @employeeId, 
                                CustomerId = @customerId, 
                                BookingId = @bookingId, 
                                TotalPrice = @totalPrice, 
                                PrePayment = @prePayment 
                            WHERE BillBookingId = @billBookingId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@billBookingId", bill.BillBookingId);
                cmd.Parameters.AddWithValue("@employeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("@customerId", bill.CustomerId);
                cmd.Parameters.AddWithValue("@bookingId", bill.BookingId);
                cmd.Parameters.AddWithValue("@totalPrice", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@prePayment", bill.PrePayment);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi cập nhật hóa đơn: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Xóa hóa đơn
        public bool DeleteBillBooking(string billBookingId)
        {
            string query = "DELETE FROM billbooking WHERE BillBookingId = @billBookingId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@billBookingId", billBookingId);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Tìm kiếm hóa đơn theo ID hoặc CustomerId
        public List<BillBookingDTO> Search(string keyword)
        {
            string query = @"SELECT * FROM billbooking 
                            WHERE BillBookingId LIKE @keyword 
                            OR CustomerId LIKE @keyword 
                            OR EmployeeId LIKE @keyword 
                            OR BookingId LIKE @keyword";
            List<BillBookingDTO> list = new List<BillBookingDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BillBookingDTO bill = new BillBookingDTO
                    {
                        BillBookingId = reader["BillBookingId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        BookingId = reader["BookingId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        PrePayment = Convert.ToDouble(reader["PrePayment"])
                    };
                    list.Add(bill);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi tìm kiếm hóa đơn: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        // 🔹 Sinh ID tự động cho hóa đơn (BB00001, BB00002, ...)
        public string GetNextId()
        {
            string query = "SELECT BillBookingId FROM billbooking ORDER BY BillBookingId DESC LIMIT 1";
            string nextId = "BB00001";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string lastId = reader["BillBookingId"].ToString();
                    int numericPart = int.Parse(lastId.Substring(2));
                    nextId = "BB" + (numericPart + 1).ToString("D5");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lấy ID hóa đơn tiếp theo: " + ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
            return nextId;
        }

        // 🔹 Lấy danh sách hóa đơn theo CustomerId
        public List<BillBookingDTO> GetBillBookingsByCustomerId(string customerId)
        {
            string query = "SELECT * FROM billbooking WHERE CustomerId = @customerId";
            List<BillBookingDTO> list = new List<BillBookingDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BillBookingDTO bill = new BillBookingDTO
                    {
                        BillBookingId = reader["BillBookingId"].ToString(),
                        EmployeeId = reader["EmployeeId"].ToString(),
                        CustomerId = reader["CustomerId"].ToString(),
                        BookingId = reader["BookingId"].ToString(),
                        TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        PrePayment = Convert.ToDouble(reader["PrePayment"])
                    };
                    list.Add(bill);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lấy hóa đơn theo CustomerId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }
    }
}
