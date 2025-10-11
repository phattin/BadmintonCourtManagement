using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;
namespace BadmintonCourtManagement.DAO
{
    public class PermissionDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy tất cả quyền
        public List<PermissionDTO> GetAllPermissions()
        {
            string query = "SELECT * FROM permission";
            List<PermissionDTO> list = new List<PermissionDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PermissionDTO()
                    {
                        PermissionId = reader["PermissionId"].ToString(),
                        PermissionName = reader["PermissionName"].ToString(),
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

        // Lấy quyền theo ID
        public PermissionDTO GetPermissionById(string id)
        {
            string query = "SELECT * FROM permission WHERE PermissionId = @PermissionId";
            PermissionDTO permission = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    permission = new PermissionDTO()
                    {
                        PermissionId = reader["PermissionId"].ToString(),
                        PermissionName = reader["PermissionName"].ToString(),
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return permission;
        }


        public bool InsertPermission(PermissionDTO permission)
        {
            string query = "INSERT INTO permission (PermissionId, PermissionName) VALUES (@PermissionId, @PermissionName)";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permission.PermissionId);
                cmd.Parameters.AddWithValue("@PermissionName", permission.PermissionName);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phân quyền: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool UpdatePermission(PermissionDTO permission)
        {
            string query = "UPDATE permission SET PermissionName = @PermissionName WHERE PermissionId = @PermissionId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permission.PermissionId);
                cmd.Parameters.AddWithValue("@PermissionName", permission.PermissionName);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phân quyền: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool checkNameExists(string name)
        {
            string query = "SELECT COUNT(*) FROM permission WHERE PermissionName = @PermissionName";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionName", name);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra tên phân quyền: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool checkNameExistsUpdate(string id, string name)
        {
            string query = "SELECT COUNT(*) FROM permission WHERE PermissionName = @PermissionName AND PermissionId != @PermissionId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionName", name);
                cmd.Parameters.AddWithValue("@PermissionId", id);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra tên phân quyền: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public List<PermissionDTO> Search(string keyword)
        {
            string query = "SELECT * FROM permission WHERE PermissionId LIKE @Keyword OR PermissionName LIKE @Keyword";
            List<PermissionDTO> list = new List<PermissionDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PermissionDTO()
                    {
                        PermissionId = reader["PermissionId"].ToString(),
                        PermissionName = reader["PermissionName"].ToString(),
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

        public string GetNextId()
        {
            string query = "SELECT PermissionId FROM permission ORDER BY PermissionId DESC LIMIT 1";
            string nextId = "P00001";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string lastId = reader["PermissionId"].ToString();
                    int numericPart = int.Parse(lastId.Substring(1));
                    nextId = "P" + (numericPart + 1).ToString("D5");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy ID tiếp theo: " + ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }

            return nextId;
        }

    }
}
