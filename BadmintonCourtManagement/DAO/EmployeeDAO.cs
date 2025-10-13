using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BadmintonCourtManagement.DAO
{
    internal class EmployeeDAO
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
                    EmployeeDTO employee = new EmployeeDTO
                    {
                        EmployeeId = reader["EmployeeId"].ToString(),
                        EmployeeName = reader["EmployeeName"].ToString(),
                        EmployeePhone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        Username = reader["Username"].ToString(),
                        RoleId = reader["RoleID"].ToString()
                    };
                    list.Add(employee);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách nhân viên: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

        public EmployeeDTO GetEmployeeById(string id)
        {
            string query = "SELECT * FROM employee WHERE EmployeeId = @EmployeeId";
            EmployeeDTO employee = null;

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    employee = new EmployeeDTO
                    {
                        EmployeeId = reader["EmployeeId"].ToString(),
                        EmployeeName = reader["EmployeeName"].ToString(),
                        EmployeePhone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        Username = reader["Username"].ToString(),
                        RoleId = reader["RoleID"].ToString()
                    };
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin nhân viên: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return employee;
        }


        // 🔹 Thêm nhân viên mới
        public bool InsertEmployee(EmployeeDTO employee)
        {
            string query = "INSERT INTO employee (EmployeeId, EmployeeName, Phone, Address, Username, RoleID) " +
                           "VALUES (@EmployeeId, @EmployeeName, @Phone, @Address, @Username, @RoleID)";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@Phone", employee.EmployeePhone);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@Username", employee.Username);
                cmd.Parameters.AddWithValue("@RoleID", employee.RoleId);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
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
            string query = "UPDATE employee SET EmployeeName = @EmployeeName, Phone = @Phone, Address = @Address, " +
                           "Username = @Username, RoleID = @RoleID WHERE EmployeeId = @EmployeeId";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@Phone", employee.EmployeePhone);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@Username", employee.Username);
                cmd.Parameters.AddWithValue("@RoleID", employee.RoleId);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message);
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
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
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
            string query = "SELECT * FROM employee WHERE EmployeeId LIKE @keyword OR EmployeeName LIKE @keyword";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeDTO employee = new EmployeeDTO
                    {
                        EmployeeId = reader["EmployeeId"].ToString(),
                        EmployeeName = reader["EmployeeName"].ToString(),
                        EmployeePhone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        Username = reader["Username"].ToString(),
                        RoleId = reader["RoleID"].ToString()
                    };
                    list.Add(employee);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm nhân viên: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

        // 🔹 Lấy ID kế tiếp (ví dụ EMP001 → EMP002)
        public string GetNextId()
        {
            string query = "SELECT EmployeeId FROM employee ORDER BY EmployeeId DESC LIMIT 1";
            string nextId = "EMP001";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastId = result.ToString(); // ví dụ: EMP005
                    int number = int.Parse(lastId.Substring(3)); // lấy 5
                    nextId = $"EMP{(number + 1):D3}"; // tạo EMP006
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã nhân viên mới: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return nextId;
        }
    }
}
