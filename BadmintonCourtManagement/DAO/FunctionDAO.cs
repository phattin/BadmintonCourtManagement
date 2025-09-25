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
        public List<FunctionDTO> GetAll()
        {
            string query = "SELECT * FROM `function`";
            List<FunctionDTO> list = new List<FunctionDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new FunctionDTO(
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

        // Lấy chức năng theo Id
        public FunctionDTO GetById(string id)
        {
            string query = "SELECT * FROM `function` WHERE Id=@Id";
            FunctionDTO fn = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    fn = new FunctionDTO(
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
            return fn;
        }

        // Thêm chức năng mới
        public bool Insert(FunctionDTO fn)
        {
            string query = "INSERT INTO `function` (Id, Name) VALUES (@Id, @Name)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", fn.Id);
                cmd.Parameters.AddWithValue("@Name", fn.Name);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật chức năng
        public bool Update(FunctionDTO fn)
        {
            string query = "UPDATE `function` SET Name=@Name WHERE Id=@Id";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", fn.Id);
                cmd.Parameters.AddWithValue("@Name", fn.Name);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa chức năng
        public bool Delete(string id)
        {
            string query = "DELETE FROM `function` WHERE Id=@Id";
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
