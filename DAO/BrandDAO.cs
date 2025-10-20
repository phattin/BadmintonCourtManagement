using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class BrandDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy tất cả thương hiệu
        public List<BrandDTO> GetAllBrands()
        {
            string query = "SELECT * FROM brand ";
            List<BrandDTO> list = new List<BrandDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BrandDTO()
                    {
                        BrandId = reader["BrandId"].ToString(),
                        BrandName = reader["BrandName"].ToString()
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

        // Lấy thương hiệu theo ID
        public BrandDTO GetById(string brandId)
        {
            string query = "SELECT * FROM brand WHERE BrandId = @BrandId";
            BrandDTO brand = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BrandId", brandId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    brand = new BrandDTO()
                    {
                        BrandId = reader["BrandId"].ToString(),
                        BrandName = reader["BrandName"].ToString()
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return brand;
        }

        // Thêm thương hiệu
        public bool InsertBrand(BrandDTO brand)
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

        // Cập nhật thương hiệu
        public bool UpdateBrand(BrandDTO brand)
        {
            string query = "UPDATE brand SET BrandName = @BrandName WHERE BrandId = @BrandId";
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

        // Xóa thương hiệu
        public bool DeleteBrand(string brandId)
        {
            string query = "DELETE FROM brand WHERE BrandId = @BrandId";
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