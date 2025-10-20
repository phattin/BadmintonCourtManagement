using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class FunctionDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy tất cả chức năng
        public List<FunctionDTO> GetAllFunctions()
        {
            string query = "SELECT * FROM function";
            List<FunctionDTO> list = new List<FunctionDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new FunctionDTO()
                    {
                        FunctionId = reader["FunctionId"].ToString(),
                        FunctionName = reader["FunctionName"].ToString()
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

        // Lấy chức năng theo ID
        public FunctionDTO GetById(string functionId)
        {
            string query = "SELECT * FROM function WHERE FunctionId = @FunctionId";
            FunctionDTO function = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@FunctionId", functionId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    function = new FunctionDTO()
                    {
                        FunctionId = reader["FunctionId"].ToString(),
                        FunctionName = reader["FunctionName"].ToString()
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return function;
        }

        // Lấy chức năng theo tên
        public List<FunctionDTO> GetByName(string functionName)
        {
            string query = "SELECT * FROM function WHERE FunctionName LIKE @FunctionName";
            List<FunctionDTO> list = new List<FunctionDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@FunctionName", "%" + functionName + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new FunctionDTO()
                    {
                        FunctionId = reader["FunctionId"].ToString(),
                        FunctionName = reader["FunctionName"].ToString()
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

        // Thêm chức năng mới
        public bool InsertFunction(FunctionDTO function)
        {
            string query = "INSERT INTO function (FunctionId, FunctionName) VALUES (@FunctionId, @FunctionName)";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@FunctionId", function.FunctionId);
                cmd.Parameters.AddWithValue("@FunctionName", function.FunctionName);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // Cập nhật chức năng
        public bool UpdateFunction(FunctionDTO function)
        {
            string query = "UPDATE function SET FunctionName = @FunctionName WHERE FunctionId = @FunctionId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@FunctionId", function.FunctionId);
                cmd.Parameters.AddWithValue("@FunctionName", function.FunctionName);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // Xóa chức năng
        public bool DeleteFunction(string functionId)
        {
            string query = "DELETE FROM function WHERE FunctionId = @FunctionId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@FunctionId", functionId);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}