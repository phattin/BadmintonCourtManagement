using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class RoleDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy 1 role theo ID
        public RoleDTO GetById(string id)
        {
            string query = "SELECT * FROM role WHERE Id=@Id AND IsDeleted=0";
            RoleDTO role = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = new RoleDTO(
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
            return role;
        }

        // Lấy tất cả role chưa xóa
        public List<RoleDTO> GetAll()
        {
            string query = "SELECT * FROM role WHERE IsDeleted=0";
            List<RoleDTO> list = new List<RoleDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RoleDTO(
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

        // Thêm role
        public bool Insert(RoleDTO role)
        {
            string query = "INSERT INTO role (Id, Name, IsDeleted) VALUES (@Id, @Name, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", role.Id);
                cmd.Parameters.AddWithValue("@Name", role.Name);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật role
        public bool Update(RoleDTO role)
        {
            string query = "UPDATE role SET Name=@Name WHERE Id=@Id AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", role.Id);
                cmd.Parameters.AddWithValue("@Name", role.Name);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm role
        public bool Delete(string id)
        {
            string query = "UPDATE role SET IsDeleted=1 WHERE Id=@Id";
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
