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
    }
}
