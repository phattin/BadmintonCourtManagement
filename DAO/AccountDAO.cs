using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class AccountDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy account theo username
        public AccountDTO GetByUsername(string username)
        {
            string query = "SELECT * FROM account WHERE Username = @Username AND IsDeleted = 0";
            AccountDTO account = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Username", username);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    account = new AccountDTO()
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        PermissionId = reader["PermissionId"].ToString(),
                        IsDeleted = Convert.ToInt32(reader["IsDeleted"])
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return account;
        }

        public bool IsUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM account WHERE Username = @Username";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Username", username);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
            finally { db.CloseConnection(); }
        }

        // Lấy tất cả account chưa xóa
        public List<AccountDTO> GetAllAccount()
        {
            string query = "SELECT * FROM account WHERE IsDeleted = 0";
            List<AccountDTO> list = new List<AccountDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new AccountDTO()
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        PermissionId = reader["PermissionId"].ToString(),
                        IsDeleted = Convert.ToInt32(reader["IsDeleted"])
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

        public List<AccountDTO> GetAllAccount1()
        {
            string query = "SELECT * FROM account";
            List<AccountDTO> list = new List<AccountDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new AccountDTO()
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        PermissionId = reader["PermissionId"].ToString(),
                        IsDeleted = Convert.ToInt32(reader["IsDeleted"])
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

        // Kiểm tra login
        public AccountDTO GetAccount(string username, string password)
        {
            string query = "SELECT * FROM account WHERE Username=@Username AND Password=@Password AND IsDeleted=0";
            AccountDTO account = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    account = new AccountDTO()
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        PermissionId = reader["PermissionId"].ToString(),
                        IsDeleted = Convert.ToInt32(reader["IsDeleted"])
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return account;
        }

        // Thêm account mới
        public bool InsertAccount(AccountDTO account)
        {
            string query = "INSERT INTO account (Username, Password, PermissionId, IsDeleted) VALUES (@Username, @Password, @PermissionId, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@PermissionId", account.PermissionId);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật account
        public bool UpdateAccount(AccountDTO account)
        {
            string query = "UPDATE account SET Password=@Password, PermissionId=@PermissionId WHERE Username=@Username AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@PermissionId", account.PermissionId);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa account (chỉ đánh dấu IsDeleted = 1)
        public bool DeleteAccount(string username)
        {
            string query = "UPDATE account SET IsDeleted=1 WHERE Username=@Username";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Username", username);
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
