using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BrandDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy Brand theo Id
        public BrandDTO GetById(string brandId)
        {
            string query = "SELECT * FROM brand WHERE BrandId=@BrandId";
            BrandDTO brand = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BrandId", brandId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    brand = new BrandDTO(
                        reader["BrandId"].ToString(),
                        reader["BrandName"].ToString()
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return brand;
        }

        // Lấy tất cả Brand
        public List<BrandDTO> GetAll()
        {
            string query = "SELECT * FROM brand";
            List<BrandDTO> list = new List<BrandDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BrandDTO(
                        reader["BrandId"].ToString(),
                        reader["BrandName"].ToString()
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

        // Thêm Brand mới
        public bool Insert(BrandDTO brand)
        {
            string query = "INSERT INTO brand (BrandId, BrandName) VALUES (@BrandId, @BrandName)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BrandId", brand.BrandId);
                cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật Brand
        public bool Update(BrandDTO brand)
        {
            string query = "UPDATE brand SET BrandName=@BrandName WHERE BrandId=@BrandId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BrandId", brand.BrandId);
                cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa Brand
        public bool Delete(string brandId)
        {
            string query = "DELETE FROM brand WHERE BrandId=@BrandId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BrandId", brandId);
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
