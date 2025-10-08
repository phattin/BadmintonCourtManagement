using BadmintonCourtManagement.DTO;
using MySql.Data.MySqlClient;
namespace BadmintonCourtManagement.DAO
{
    public class PermissionDAO
    {
        DBConnection db = new DBConnection();
        public PermissionDAO() { }

        public List<PermissionDTO> GetAllPermissions()
        {
            List<PermissionDTO> permissions = new List<PermissionDTO>();
            string query = "SELECT * FROM permission";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PermissionDTO permission = new PermissionDTO
                    {
                        PermissionId = reader.GetString("PermissionId"),
                        PermissionName = reader.GetString("PermissionName"),
                    };
                    permissions.Add(permission);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, or show a message)
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return permissions;
        }

        public PermissionDTO GetPermissionById(string permissionId)
        {
            PermissionDTO permission = null;
            string query = "SELECT * FROM permission WHERE PermissionId = @PermissionId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permissionId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    permission = new PermissionDTO
                    {
                        PermissionId = reader.GetString("PermissionId"),
                        PermissionName = reader.GetString("PermissionName"),
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy phân quyền: " + ex.Message);
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
