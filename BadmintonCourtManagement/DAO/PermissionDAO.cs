using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

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

        // Thêm quyền
        public bool InsertPermission(PermissionDTO permission)
        {
            string query = "INSERT INTO permission (PermissionId, PermissionName) VALUES (@PermissionId, @PermissionName)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permission.PermissionId);
                cmd.Parameters.AddWithValue("@PermissionName", permission.PermissionName);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật quyền
        public bool UpdatePermission(PermissionDTO permission)
        {
            string query = "UPDATE permission SET PermissionName = @PermissionName WHERE PermissionId = @PermissionId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permission.PermissionId);
                cmd.Parameters.AddWithValue("@PermissionName", permission.PermissionName);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa quyền   
        public bool DeletePermission(string id)
        {
            string query = "DELETE FROM permission WHERE PermissionId = @PermissionId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", id);
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