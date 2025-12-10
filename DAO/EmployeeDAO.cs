using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;

namespace BadmintonCourtManagement.DAO
{
    public class EmployeeDAO
    {
        private DBConnection db;

        public EmployeeDAO()
        {
            db = new DBConnection();
        }

        // 🔹 Lấy toàn bộ nhân viên
        public List<EmployeeDTO> GetAllEmployees()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            string query = "SELECT * FROM employee";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var phoneValue = reader["Phone"].ToString().Trim();
                    var employee = new EmployeeDTO
                    {
                        EmployeeId = reader["EmployeeId"].ToString(),
                        EmployeeName = reader["EmployeeName"].ToString(),
                        EmployeePhone = reader["Phone"].ToString().Trim(),
                        Address = reader["Address"].ToString(),
                        RoleId = reader["RoleId"].ToString(),
                    };
                    list.Add(employee);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //throw new Exception("Loi GetAllEmployees: " + ex.Message, ex);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

        public EmployeeDTO GetEmployeeById(string id)
        {
            string query = "SELECT* FROM employee WHERE EmployeeId = @EmployeeId";
            EmployeeDTO employee = null;

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var phoneValue = reader["Phone"].ToString().Trim();
                    employee = new EmployeeDTO
                    {
                        EmployeeId = reader["EmployeeId"].ToString(),
                        EmployeeName = reader["EmployeeName"].ToString(),
                        EmployeePhone = string.IsNullOrEmpty(phoneValue) ? "0987654321" : phoneValue,
                        Address = reader["Address"].ToString(),
                        RoleId = reader["RoleId"].ToString(),
                    };
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lấy thông tin nhân viên: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return employee;
        }

        // public EmployeeDTO GetEmployeeByUsername(string username)
        // {
        //     string query = "SELECT * FROM employee join account on employee.EmployeeId = account.EmployeeId WHERE account.Username = @Username";
        //     EmployeeDTO employee = null;

        //     try
        //     {
        //         db.OpenConnection();
        //         MySqlCommand cmd = new MySqlCommand(query, db.Connection);
        //         cmd.Parameters.AddWithValue("@Username", username);
        //         MySqlDataReader reader = cmd.ExecuteReader();

        //         if (reader.Read())
        //         {
        //             var phoneValue = reader["Phone"].ToString().Trim();
        //             employee = new EmployeeDTO
        //             {
        //                 EmployeeId = reader["EmployeeId"].ToString(),
        //                 EmployeeName = reader["EmployeeName"].ToString(),
        //                 EmployeePhone = string.IsNullOrEmpty(phoneValue) ? "0987654321" : phoneValue,
        //                 Address = reader["Address"].ToString(),
        //                 RoleId = reader["RoleId"].ToString(),
        //             };
        //         }

        //         reader.Close();
        //     }
        //     catch (Exception ex)
        //     {
        //         //MessageBox.Show("Lỗi khi lấy thông tin nhân viên: " + ex.Message);
        //     }
        //     finally
        //     {
        //         db.CloseConnection();
        //     }

        //     return employee;
        // }

        // 🔹 Thêm nhân viên mới
        public bool InsertEmployee(EmployeeDTO employee)
        {
            string query = "INSERT INTO employee (EmployeeId, EmployeeName, Phone, Address, RoleID) " +
                           "VALUES (@EmployeeId, @EmployeeName, @Phone, @Address, @RoleId)";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@Phone", employee.EmployeePhone);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@RoleId", employee.RoleId);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Cập nhật nhân viên
        public bool UpdateEmployee(EmployeeDTO employee)
        {
            string query = "UPDATE employee SET EmployeeName = @EmployeeName, Phone = @Phone, Address = @Address, RoleId = @RoleId WHERE EmployeeId = @EmployeeId";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@Phone", employee.EmployeePhone);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@RoleId", employee.RoleId);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Xóa nhân viên
        public bool DeleteEmployee(string employeeId)
        {
            string query = "DELETE FROM employee WHERE EmployeeId = @EmployeeId";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Tìm kiếm nhân viên theo từ khóa (ID hoặc tên)
        public List<EmployeeDTO> Search(string keyword)
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            string query = @"SELECT * FROM employee 
                 WHERE EmployeeId   LIKE @keyword
                    OR EmployeeName LIKE @keyword
                    OR Phone        LIKE @keyword
                    OR Address      LIKE @keyword";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var phoneValue = reader["Phone"].ToString().Trim();
                    var employee = new EmployeeDTO
                    {
                        EmployeeId = reader["EmployeeId"].ToString(),
                        EmployeeName = reader["EmployeeName"].ToString(),
                        EmployeePhone = string.IsNullOrEmpty(phoneValue) ? "0987654321" : phoneValue,
                        Address = reader["Address"].ToString(),
                        RoleId = reader["RoleId"].ToString()
                    };
                    list.Add(employee);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi tìm kiếm nhân viên: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

        // 🔹 Lấy ID kế tiếp (ví dụ E00001 → E00002)
        public string GetNextId()
        {
            string query = "SELECT EmployeeId FROM employee ORDER BY EmployeeId DESC LIMIT 1";
            string nextId = "E00001";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastId = result.ToString().Trim(); // ví dụ: "E00005"
                    int number = int.Parse(lastId.Substring(1)); // lấy toàn bộ phần số: "00005" → 5
                    nextId = $"E{number + 1:D5}"; // tạo ID mới đúng format 5 chữ số
                }
            }
            catch { }
            finally
            {
                db.CloseConnection();
            }

            return nextId;
        }


        // Kiểm tra phone đã tồn tại khi thêm mới
        public bool isPhoneExists(string phone)
        {
            string query = "SELECT COUNT(*) FROM employee WHERE Phone = @Phone";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Phone", phone.Trim());

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // Kiểm tra phone đã tồn tại khi cập nhật (loại trừ ID hiện tại)
        public bool isPhoneExistsUpdate(string phone, string employeeId)
        {
            string query = "SELECT COUNT(*) FROM employee WHERE Phone = @Phone AND EmployeeId <> @EmployeeId";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Phone", phone.Trim());
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

    }

}
