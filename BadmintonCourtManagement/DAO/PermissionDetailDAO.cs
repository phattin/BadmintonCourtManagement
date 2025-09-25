using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PermissionDetailDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy 1 permission detail theo PermissionId + FunctionId
        public PermissionDetailDTO GetById(string permissionId, string functionId)
        {
            string query = "SELECT * FROM permission_detail WHERE PermissionId=@PermissionId AND FunctionId=@FunctionId AND IsDeleted=0";
            PermissionDetailDTO detail = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permissionId);
                cmd.Parameters.AddWithValue("@FunctionId", functionId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    detail = new PermissionDetailDTO(
                        reader["PermissionId"].ToString(),
                        reader["FunctionId"].ToString(),
                        (PermissionDetailDTO.Option)Convert.ToInt32(reader["PermissionOption"])
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return detail;
        }

        // Lấy tất cả permission detail
        public List<PermissionDetailDTO> GetAll()
        {
            string query = "SELECT * FROM permission_detail WHERE IsDeleted=0";
            List<PermissionDetailDTO> list = new List<PermissionDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PermissionDetailDTO(
                        reader["PermissionId"].ToString(),
                        reader["FunctionId"].ToString(),
                        (PermissionDetailDTO.Option)Convert.ToInt32(reader["PermissionOption"])
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

        // Thêm permission detail
        public bool Insert(PermissionDetailDTO detail)
        {
            string query = "INSERT INTO permission_detail (PermissionId, FunctionId, PermissionOption, IsDeleted) " +
                           "VALUES (@PermissionId, @FunctionId, @PermissionOption, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", detail.PermissionId);
                cmd.Parameters.AddWithValue("@FunctionId", detail.FunctionId);
                cmd.Parameters.AddWithValue("@PermissionOption", (int)detail.PermissionOption);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật permission detail
        public bool Update(PermissionDetailDTO detail)
        {
            string query = "UPDATE permission_detail SET PermissionOption=@PermissionOption " +
                           "WHERE PermissionId=@PermissionId AND FunctionId=@FunctionId AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", detail.PermissionId);
                cmd.Parameters.AddWithValue("@FunctionId", detail.FunctionId);
                cmd.Parameters.AddWithValue("@PermissionOption", (int)detail.PermissionOption);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm (IsDeleted=1)
        public bool Delete(string permissionId, string functionId)
        {
            string query = "UPDATE permission_detail SET IsDeleted=1 WHERE PermissionId=@PermissionId AND FunctionId=@FunctionId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permissionId);
                cmd.Parameters.AddWithValue("@FunctionId", functionId);
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
