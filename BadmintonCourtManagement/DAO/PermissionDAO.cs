using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PermissionDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy 1 permission theo Id
        public PermissionDTO GetById(string id)
        {
            string query = "SELECT * FROM permission WHERE Id=@Id AND IsDeleted=0";
            PermissionDTO permission = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    permission = new PermissionDTO(
                        reader["Id"].ToString(),
                        reader["Name"].ToString()
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return permission;
        }

        // Lấy tất cả permission chưa xóa
        public List<PermissionDTO> GetAll()
        {
            string query = "SELECT * FROM permission WHERE IsDeleted=0";
            List<PermissionDTO> list = new List<PermissionDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PermissionDTO(
                        reader["Id"].ToString(),
                        reader["Name"].ToString()
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

        // Thêm permission
        public bool Insert(PermissionDTO permission)
        {
            string query = "INSERT INTO permission (Id, Name, IsDeleted) VALUES (@Id, @Name, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", permission.Id);
                cmd.Parameters.AddWithValue("@Name", permission.Name);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật permission
        public bool Update(PermissionDTO permission)
        {
            string query = "UPDATE permission SET Name=@Name WHERE Id=@Id AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", permission.Id);
                cmd.Parameters.AddWithValue("@Name", permission.Name);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm permission (IsDeleted = 1)
        public bool Delete(string id)
        {
            string query = "UPDATE permission SET IsDeleted=1 WHERE Id=@Id";
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
