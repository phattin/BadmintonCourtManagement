using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{ 
    public class RoleDAO
    {
        private DBConnection db = new DBConnection();

        //Insert
        public bool InsertRole(RoleDTO role)
        {
            string query = "INSERT INTO role (RoleId, RoleName) VALUES (@RoleId, @RoleName)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@RoleId", role.RoleId);
                cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting role data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Update
        public bool UpdateRole(RoleDTO role)
        {
            string query = "UPDATE role SET RoleName = @RoleName WHERE RoleId = @RoleId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@RoleId", role.RoleId);
                cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating role data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // detele
        public bool DeleteRole(string roleId)
        { 
            string query = "DELETE FROM role WHERE RoleId = @RoleId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting role data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Get by id
        public RoleDTO GetRoleById(string roleId)
        {
            string query = "SELECT * FROM role WHERE RoleId = @RoleId";
            RoleDTO role = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = new RoleDTO()
                    {
                        RoleId = reader["RoleId"].ToString(),
                        RoleName = reader["RoleName"].ToString()
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving role data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return role;
        }

        // Lấy tất cả role chưa xóa
        public List<RoleDTO> GetAllRoles()
        {
            string query = "SELECT * FROM role ";
            List<RoleDTO> list = new List<RoleDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RoleDTO()
                    {
                        RoleId = reader["RoleId"].ToString(),
                        RoleName = reader["RoleName"].ToString()
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
    }
}