using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PriceRuleDAO
    {
        private DBConnection db = new DBConnection();

        //crate 
        public bool InsertPriceRule(PriceRuleDTO priceRule)
        {
            string query = "INSERT INTO pricerule (PriceRuleId, Price, StartTime, EndTime, StartDate, EndDate, Description, Status)"
            + " VALUES (@PriceRuleId, @Price, @StartTime, @EndTime, @StartDate, @EndDate, @Description, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PriceRuleId", priceRule.PriceRuleId);
                cmd.Parameters.AddWithValue("@Price", priceRule.Price);
                cmd.Parameters.AddWithValue("@StartTime", priceRule.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", priceRule.EndTime);
                cmd.Parameters.AddWithValue("@StartDate", priceRule.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", priceRule.EndDate);
                cmd.Parameters.AddWithValue("@Description", priceRule.Description);
                cmd.Parameters.AddWithValue("@Status", priceRule.IsActive);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting price rule data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // read
        public List<PriceRuleDTO> GetAllPriceRules()
        {
            string query = "SELECT * FROM pricerule ";
            List<PriceRuleDTO> priceRules = new List<PriceRuleDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PriceRuleDTO priceRule = new PriceRuleDTO
                    {
                        PriceRuleId = reader["PriceRuleId"].ToString(),
                        Price = double.Parse(reader["Price"].ToString()),
                        StartTime = TimeOnly.Parse(reader["StartTime"].ToString()),
                        EndTime = TimeOnly.Parse(reader["EndTime"].ToString()),
                        StartDate = DateOnly.Parse(reader["StartDate"].ToString()),
                        EndDate = DateOnly.Parse(reader["EndDate"].ToString()),
                        Description = reader["Description"].ToString(),
                        IsActive = int.Parse(reader["Status"].ToString())
                    };
                    priceRules.Add(priceRule);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving price rule data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return priceRules;
        }

        // Get by id
        public PriceRuleDTO GetPriceRuleById(string priceRuleId)
        {
            string query = "SELECT * FROM pricerule WHERE PriceRuleId = @PriceRuleId";
            PriceRuleDTO priceRule = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PriceRuleId", priceRuleId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    priceRule = new PriceRuleDTO
                    {
                        PriceRuleId = reader["PriceRuleId"].ToString(),
                        Price = double.Parse(reader["Price"].ToString()),
                        StartTime = TimeOnly.Parse(reader["StartTime"].ToString()),
                        EndTime = TimeOnly.Parse(reader["EndTime"].ToString()),
                        StartDate = DateOnly.Parse(reader["StartDate"].ToString()),
                        EndDate = DateOnly.Parse(reader["EndDate"].ToString()),
                        Description = reader["Description"].ToString(),
                        IsActive = int.Parse(reader["Status"].ToString())
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving price rule data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return priceRule;
        }

        //update
        public bool UpdatePriceRule(PriceRuleDTO priceRule)
        {
            string query = "UPDATE pricerule SET Price = @Price, StartTime = @StartTime, EndTime = @EndTime, StartDate = @StartDate, EndDate = @EndDate, Description = @Description, Status = @Status"
            + " WHERE PriceRuleId = @PriceRuleId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PriceRuleId", priceRule.PriceRuleId);
                cmd.Parameters.AddWithValue("@Price", priceRule.Price);
                cmd.Parameters.AddWithValue("@StartTime", priceRule.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", priceRule.EndTime);
                cmd.Parameters.AddWithValue("@StartDate", priceRule.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", priceRule.EndDate);
                cmd.Parameters.AddWithValue("@Description", priceRule.Description);
                cmd.Parameters.AddWithValue("@Status", priceRule.IsActive);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating price rule data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // delete
        public bool DeletePriceRule(string priceRuleId)
        {
            string query = "DELETE FROM pricerule WHERE PriceRuleId = @PriceRuleId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PriceRuleId", priceRuleId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting price rule data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
    }
}

