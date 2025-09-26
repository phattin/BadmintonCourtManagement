using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace BadmintonCourtManagement.DAO
{
    internal class DBConnection
    {
        // Chuỗi kết nối tới MySQL qua XAMPP
        private string connectionString = "server=localhost;port=3306;database=badmintoncourtmanagement;uid=root;password=;";
        private MySqlConnection connection;

        // Constructor
        public DBConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection Connection
        {
            get { return connection; }
        }


        // Mở kết nối
        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi mở kết nối: " + ex.Message);
            }
        }

        // Đóng kết nối
        public void CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }

        // Thực thi câu lệnh SELECT trả về DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi truy vấn: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        // Thực thi INSERT, UPDATE, DELETE
        public int ExecuteNonQuery(string query)
        {
            int result = 0;
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi thực thi câu lệnh: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
    }
}
