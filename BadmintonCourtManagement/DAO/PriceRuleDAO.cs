using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PriceRuleDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy 1 PriceRule theo Id
        public PriceRuleDTO GetById(string id)
        {
            string query = "SELECT * FROM price_rule WHERE Id=@Id AND IsDeleted=0";
            PriceRuleDTO rule = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    rule = new PriceRuleDTO(
                        reader["Id"].ToString(),
                        Convert.ToDouble(reader["Price"]),
                        TimeOnly.FromTimeSpan((TimeSpan)reader["StartTime"]),
                        TimeOnly.FromTimeSpan((TimeSpan)reader["EndTime"]),
                        DateOnly.FromDateTime(Convert.ToDateTime(reader["StartDate"])),
                        DateOnly.FromDateTime(Convert.ToDateTime(reader["EndDate"])),
                        reader["Description"].ToString(),
                        Convert.ToBoolean(reader["IsActive"])
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return rule;
        }

        // Lấy tất cả PriceRule chưa xóa
        public List<PriceRuleDTO> GetAll()
        {
            string query = "SELECT * FROM price_rule WHERE IsDeleted=0";
            List<PriceRuleDTO> list = new List<PriceRuleDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PriceRuleDTO(
                        reader["Id"].ToString(),
                        Convert.ToDouble(reader["Price"]),
                        TimeOnly.FromTimeSpan((TimeSpan)reader["StartTime"]),
                        TimeOnly.FromTimeSpan((TimeSpan)reader["EndTime"]),
                        DateOnly.FromDateTime(Convert.ToDateTime(reader["StartDate"])),
                        DateOnly.FromDateTime(Convert.ToDateTime(reader["EndDate"])),
                        reader["Description"].ToString(),
                        Convert.ToBoolean(reader["IsActive"])
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

        // Thêm PriceRule
        public bool Insert(PriceRuleDTO rule)
        {
            string query = @"INSERT INTO price_rule 
                             (Id, Price, StartTime, EndTime, StartDate, EndDate, Description, IsActive, IsDeleted) 
                             VALUES (@Id, @Price, @StartTime, @EndTime, @StartDate, @EndDate, @Description, @IsActive, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", rule.Id);
                cmd.Parameters.AddWithValue("@Price", rule.Price);
                cmd.Parameters.AddWithValue("@StartTime", rule.StartTime.ToTimeSpan());
                cmd.Parameters.AddWithValue("@EndTime", rule.EndTime.ToTimeSpan());
                cmd.Parameters.AddWithValue("@StartDate", rule.StartDate.ToDateTime(TimeOnly.MinValue));
                cmd.Parameters.AddWithValue("@EndDate", rule.EndDate.ToDateTime(TimeOnly.MinValue));
                cmd.Parameters.AddWithValue("@Description", rule.Description);
                cmd.Parameters.AddWithValue("@IsActive", rule.IsActive);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật PriceRule
        public bool Update(PriceRuleDTO rule)
        {
            string query = @"UPDATE price_rule 
                             SET Price=@Price, StartTime=@StartTime, EndTime=@EndTime, 
                                 StartDate=@StartDate, EndDate=@EndDate, Description=@Description, IsActive=@IsActive
                             WHERE Id=@Id AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", rule.Id);
                cmd.Parameters.AddWithValue("@Price", rule.Price);
                cmd.Parameters.AddWithValue("@StartTime", rule.StartTime.ToTimeSpan());
                cmd.Parameters.AddWithValue("@EndTime", rule.EndTime.ToTimeSpan());
                cmd.Parameters.AddWithValue("@StartDate", rule.StartDate.ToDateTime(TimeOnly.MinValue));
                cmd.Parameters.AddWithValue("@EndDate", rule.EndDate.ToDateTime(TimeOnly.MinValue));
                cmd.Parameters.AddWithValue("@Description", rule.Description);
                cmd.Parameters.AddWithValue("@IsActive", rule.IsActive);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm PriceRule
        public bool Delete(string id)
        {
            string query = "UPDATE price_rule SET IsDeleted=1 WHERE Id=@Id";
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
