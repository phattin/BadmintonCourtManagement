using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class CourtDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy tất cả sân
        public List<CourtDTO> GetAll()
        {
            string query = "SELECT * FROM court";
            List<CourtDTO> list = new List<CourtDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var status = reader["Status"].ToString() == "Active"
                        ? CourtDTO.Option.Active
                        : CourtDTO.Option.UnderMaintenance;

                    list.Add(new CourtDTO(
                        reader["CourtId"].ToString(),
                        reader["CourtName"].ToString(),
                        status
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

        // Lấy sân theo Id
        public CourtDTO GetById(string id)
        {
            string query = "SELECT * FROM court WHERE CourtId=@CourtId";
            CourtDTO court = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtId", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var status = reader["Status"].ToString() == "Active"
                        ? CourtDTO.Option.Active
                        : CourtDTO.Option.UnderMaintenance;

                    court = new CourtDTO(
                        reader["CourtId"].ToString(),
                        reader["CourtName"].ToString(),
                        status
                    );
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return court;
        }

        // Thêm sân mới
        public bool Insert(CourtDTO court)
        {
            string query = "INSERT INTO court (CourtId, CourtName, Status) VALUES (@CourtId, @CourtName, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtId", court.Id);
                cmd.Parameters.AddWithValue("@CourtName", court.Name);
                cmd.Parameters.AddWithValue("@Status", court.Status.ToString());
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật sân
        public bool Update(CourtDTO court)
        {
            string query = "UPDATE court SET CourtName=@CourtName, Status=@Status WHERE CourtId=@CourtId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtId", court.Id);
                cmd.Parameters.AddWithValue("@CourtName", court.Name);
                cmd.Parameters.AddWithValue("@Status", court.Status.ToString());
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa sân
        public bool Delete(string courtId)
        {
            string query = "DELETE FROM court WHERE CourtId=@CourtId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtId", courtId);
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
