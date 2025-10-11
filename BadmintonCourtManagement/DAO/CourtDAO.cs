using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;

namespace BadmintonCourtManagement.DAO
{
    internal class CourtDAO
    {
        private DBConnection db;
        public CourtDAO()
        {
            db = new DBConnection();
        }

        public List<CourtDTO> GetAllCourts()
        {
            List<CourtDTO> list = new List<CourtDTO>();
            string query = "SELECT * FROM court";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CourtDTO court = new CourtDTO
                    {
                        CourtId = reader["CourtId"].ToString(),
                        CourtName = reader["CourtName"].ToString(),
                        Status = (CourtDTO.Option)Enum.Parse(typeof(CourtDTO.Option), reader["Status"].ToString())
                    };
                    list.Add(court);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách sân: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        public bool UpdateCourt(CourtDTO court)
        {
            string query = "UPDATE court SET CourtName = @name, Status = @status WHERE CourtId = @id";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@name", court.CourtName);
                cmd.Parameters.AddWithValue("@status", court.Status.ToString());
                cmd.Parameters.AddWithValue("@id", court.CourtId);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi cập nhật sân: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
            
        public bool DeleteCourt(string courtId)
        {
            string query = "DELETE FROM courts WHERE CourtId = @CourtId";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtId", courtId);

                int result = cmd.ExecuteNonQuery();
                db.CloseConnection();

                // Trả về true nếu có ít nhất 1 dòng bị xóa
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa sân: " + ex.Message);
                return false; 
            }
        }

    }
}
