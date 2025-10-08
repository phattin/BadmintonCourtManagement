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
                Console.WriteLine("Lỗi khi thêm phân quyền: " + ex.Message);
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
                Console.WriteLine("Lỗi khi cập nhật phân quyền: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

    }
}
