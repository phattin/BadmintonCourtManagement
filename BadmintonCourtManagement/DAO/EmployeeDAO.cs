using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class EmployeeDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy tất cả nhân viên
        public List<EmployeeDTO> GetAll()
        {
            string query = "SELECT * FROM employee";
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new EmployeeDTO(
                        reader["EmployeeId"].ToString(),
                        reader["EmployeeName"].ToString(),
                        reader["Phone"].ToString(),
                        reader["Address"].ToString(),
                        reader["Username"].ToString(),
                        reader["RoleId"].ToString()
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

        // Lấy nhân viên theo Id
        public EmployeeDTO GetById(string id)
        {
            string query = "SELECT * FROM employee WHERE EmployeeId=@EmployeeId";
            EmployeeDTO employee = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    employee = new EmployeeDTO(
                        reader["EmployeeId"].ToString(),
                        reader["EmployeeName"].ToString(),
                        reader["Phone"].ToString(),
                        reader["Address"].ToString(),
                        reader["Username"].ToString(),
                        reader["RoleId"].ToString()
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return employee;
        }

        // Thêm nhân viên mới
        public bool Insert(EmployeeDTO employee)
        {
            string query = @"INSERT INTO employee 
                            (EmployeeId, EmployeeName, Phone, Address, Username, RoleId) 
                            VALUES (@EmployeeId, @EmployeeName, @Phone, @Address, @Username, @RoleId)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.Name);
                cmd.Parameters.AddWithValue("@Phone", employee.Phone);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@Username", employee.Username);
                cmd.Parameters.AddWithValue("@RoleId", employee.RoleId);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật thông tin nhân viên
        public bool Update(EmployeeDTO employee)
        {
            string query = @"UPDATE employee 
                             SET EmployeeName=@EmployeeName, Phone=@Phone, Address=@Address, Username=@Username, RoleId=@RoleId 
                             WHERE EmployeeId=@EmployeeId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.Name);
                cmd.Parameters.AddWithValue("@Phone", employee.Phone);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@Username", employee.Username);
                cmd.Parameters.AddWithValue("@RoleId", employee.RoleId);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa nhân viên
        public bool Delete(string employeeId)
        {
            string query = "DELETE FROM employee WHERE EmployeeId=@EmployeeId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
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
