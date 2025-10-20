using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;

namespace BadmintonCourtManagement.DAO
{
    public class CourtDAO
    {
        private DBConnection db;
        public CourtDAO()
        {
            db = new DBConnection();
        }

        // 🔹 Lấy danh sách tất cả sân
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
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lấy danh sách sân: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        // 🔹 Lấy sân theo ID
        public CourtDTO GetCourtById(string id)
        {
            string query = "SELECT * FROM court WHERE CourtId = @id";
            CourtDTO court = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    court = new CourtDTO
                    {
                        CourtId = reader["CourtId"].ToString(),
                        CourtName = reader["CourtName"].ToString(),
                        Status = (CourtDTO.Option)Enum.Parse(typeof(CourtDTO.Option), reader["Status"].ToString())
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lấy sân theo ID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return court;
        }

        // 🔹 Thêm sân mới
        public bool InsertCourt(CourtDTO court)
        {
            string query = "INSERT INTO court (CourtId, CourtName, Status) VALUES (@id, @name, @status)";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", court.CourtId);
                cmd.Parameters.AddWithValue("@name", court.CourtName);
                cmd.Parameters.AddWithValue("@status", court.Status.ToString());
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi thêm sân: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Cập nhật sân
        public bool UpdateCourt(CourtDTO court)
        {
            string query = "UPDATE court SET CourtName = @name, Status = @status WHERE CourtId = @id";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", court.CourtId);
                cmd.Parameters.AddWithValue("@name", court.CourtName);
                cmd.Parameters.AddWithValue("@status", court.Status.ToString());
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi cập nhật sân: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Xóa sân
        public bool DeleteCourt(string courtId)
        {
            string query = "DELETE FROM court WHERE CourtId = @CourtId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtId", courtId);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi xóa sân: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Kiểm tra tên sân đã tồn tại (dùng khi thêm mới)
        public bool CheckNameExists(string name)
        {
            string query = "SELECT COUNT(*) FROM court WHERE CourtName = @CourtName";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtName", name);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi kiểm tra tên sân: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Kiểm tra tên sân trùng khi cập nhật (bỏ qua sân hiện tại)
        public bool CheckNameExistsUpdate(string id, string name)
        {
            string query = "SELECT COUNT(*) FROM court WHERE CourtName = @CourtName AND CourtId != @CourtId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@CourtName", name);
                cmd.Parameters.AddWithValue("@CourtId", id);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi kiểm tra tên sân (update): " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 🔹 Tìm kiếm sân theo ID hoặc tên
        public List<CourtDTO> Search(string keyword)
        {
            string query = "SELECT * FROM court WHERE CourtId LIKE @keyword OR CourtName LIKE @keyword";
            List<CourtDTO> list = new List<CourtDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
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
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi tìm kiếm sân: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        // 🔹 Sinh ID tự động cho sân (theo kiểu CO00001, CO00002, ...)
        public string GetNextId()
        {
            string query = "SELECT CourtId FROM court ORDER BY CourtId DESC LIMIT 1";
            string nextId = "CO00001";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string lastId = reader["CourtId"].ToString();
                    int numericPart = int.Parse(lastId.Substring(2));
                    nextId = "CO" + (numericPart + 1).ToString("D5");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lấy ID sân tiếp theo: " + ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
            return nextId;
        }

        public List<CourtDTO> FilterByStatus(string status)
        {
            List<CourtDTO> list = new List<CourtDTO>();
            string query;

            // Nếu không chọn trạng thái hoặc chọn "Tất cả" thì lấy toàn bộ
            if (string.IsNullOrEmpty(status) || status == "all")
                query = "SELECT * FROM court";
            else
                query = "SELECT * FROM court WHERE Status = @status";

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                if (!string.IsNullOrEmpty(status) && status != "all")
                    cmd.Parameters.AddWithValue("@status", status);

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
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi lọc sân theo trạng thái: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

    }
}
