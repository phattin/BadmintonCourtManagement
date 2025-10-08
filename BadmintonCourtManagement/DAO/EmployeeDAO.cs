using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;

namespace BadmintonCourtManagement.DAO
{
    internal class EmployeeDAO
    {
        private DBConnection db;
        public EmployeeDAO()
        {
            db = new DBConnection();
        }

        public List<EmployeeDTO> GetAllCourts()
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
                        RoleId = reader["RoleID"].ToString(),
                    };
                    list.Add(employee);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách nhân viên: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }
    }
}
