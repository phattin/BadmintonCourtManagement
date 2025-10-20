using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PermissionDetailDAO
    {
        private DBConnection db = new DBConnection();
        public bool InsertPermissionDetail(PermissionDetailDTO permissionDetail)
        {
            string query = "INSERT INTO permissiondetail (PermissionId, FunctionId, Option) " +
                           "VALUES (@PermissionId, @FunctionId, @Option)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permissionDetail.PermissionId);
                cmd.Parameters.AddWithValue("@FunctionId", permissionDetail.FunctionId);
                cmd.Parameters.AddWithValue("@Option", permissionDetail.Option.ToString());
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error inserting permission detail: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // get all
        public List<PermissionDetailDTO> GetPermissionDetailsByPermissionId(string permissionId)
        {
            List<PermissionDetailDTO> permissionDetails = new List<PermissionDetailDTO>();
            string query = "SELECT * FROM permissiondetail WHERE PermissionId = @PermissionId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permissionId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PermissionDetailDTO detail = new PermissionDetailDTO
                    {
                        PermissionId = reader["PermissionId"].ToString(),
                        FunctionId = reader["FunctionId"].ToString(),
                        Option = reader["Option"].ToString()
                    };
                    permissionDetails.Add(detail);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error retrieving permission details: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return permissionDetails;
        }

        //update
        public bool DeletePermissionDetailsByPermissionId(string permissionId)
        {
            string query = "DELETE FROM permissiondetail WHERE PermissionId = @PermissionId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permissionId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("L?i khi xóa chi ti?t quy?n: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // get add by function id
        public List<PermissionDetailDTO> GetPermissionDetailsByFunctionId(string functionId)
        {
            List<PermissionDetailDTO> permissionDetails = new List<PermissionDetailDTO>();
            string query = "SELECT * FROM permissiondetail WHERE FunctionId = @FunctionId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@FunctionId", functionId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PermissionDetailDTO detail = new PermissionDetailDTO
                    {
                        PermissionId = reader["PermissionId"].ToString(),
                        FunctionId = reader["FunctionId"].ToString(),
                        Option = reader["Option"].ToString()
                    };
                    permissionDetails.Add(detail);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error retrieving permission details by FunctionId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return permissionDetails;
        }

        // get edit by permission id
        public List<PermissionDetailDTO> GetPermissionDetailsByOption(string permissionId)
        {
            List<PermissionDetailDTO> permissionDetails = new List<PermissionDetailDTO>();
            string query = "SELECT * FROM permissiondetail WHERE PermissionId = @PermissionId";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PermissionId", permissionId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PermissionDetailDTO detail = new PermissionDetailDTO
                    {
                        PermissionId = reader["PermissionId"].ToString(),
                        FunctionId = reader["FunctionId"].ToString(),
                        Option = reader["Option"].ToString()
                    };
                    permissionDetails.Add(detail);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error retrieving permission details by Option: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return permissionDetails;
        }

        public List<PermissionDetailDTO> GetAllPermissionDetails()
        {
            List<PermissionDetailDTO> permissionDetails = new List<PermissionDetailDTO>();
            string query = "SELECT * FROM permissiondetail";
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PermissionDetailDTO detail = new PermissionDetailDTO
                    {
                        PermissionId = reader["PermissionId"].ToString(),
                        FunctionId = reader["FunctionId"].ToString(),
                        Option = reader["Option"].ToString()
                    };
                    permissionDetails.Add(detail);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error retrieving all permission details: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return permissionDetails;
        }

    }
}