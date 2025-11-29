using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PriceRuleDAO
    {
        private DBConnection db = new DBConnection();

        //create 
        public bool InsertPriceRule(PriceRuleDTO priceRule)
        {
            string query = "INSERT INTO pricerule (PriceRuleId, Price, StartTime, EndTime, StartDate, EndDate, EndType, Description, Status)"
            + " VALUES (@PriceRuleId, @Price, @StartTime, @EndTime, @StartDate, @EndDate, @EndType, @Description, @Status)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PriceRuleId", priceRule.PriceRuleId);
                cmd.Parameters.AddWithValue("@Price", priceRule.Price);

                cmd.Parameters.AddWithValue("@StartTime", priceRule.StartTime.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@EndTime", priceRule.EndTime.ToString("HH:mm:ss"));

                if (priceRule.StartDate == null)
                {
                    cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StartDate", priceRule.StartDate.Value.ToString("yyyy-MM-dd"));
                }
                if (priceRule.EndDate == null)
                {
                    cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EndDate", priceRule.EndDate.Value.ToString("yyyy-MM-dd"));
                }

                cmd.Parameters.AddWithValue("@EndType", priceRule.EndType);
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
            string query = "SELECT * FROM pricerule";
            List<PriceRuleDTO> priceRules = new List<PriceRuleDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PriceRuleDTO priceRule = new PriceRuleDTO();
                    priceRule.PriceRuleId = reader["PriceRuleId"].ToString();
                    if (reader["Price"] != DBNull.Value)
                        priceRule.Price = double.Parse(reader["Price"].ToString());
                    if (reader["StartDate"] != DBNull.Value)
                    {
                        priceRule.StartDate = DateOnly.FromDateTime(Convert.ToDateTime(reader["StartDate"]));
                    }

                    if (reader["EndDate"] != DBNull.Value)
                    {
                        priceRule.EndDate = DateOnly.FromDateTime(Convert.ToDateTime(reader["EndDate"]));
                    }
                    if (reader["StartTime"] != DBNull.Value)
                    {
                        if (reader["StartTime"] is TimeSpan ts)
                            priceRule.StartTime = TimeOnly.FromTimeSpan(ts);
                        else
                            priceRule.StartTime = TimeOnly.Parse(reader["StartTime"].ToString());
                    }
                    if (reader["EndTime"] != DBNull.Value)
                    {
                        if (reader["EndTime"] is TimeSpan ts)
                            priceRule.EndTime = TimeOnly.FromTimeSpan(ts);
                        else
                            priceRule.EndTime = TimeOnly.Parse(reader["EndTime"].ToString());
                    }

                    priceRule.EndType = reader["EndType"].ToString();
                    priceRule.Description = reader["Description"].ToString();
                    priceRule.IsActive = int.Parse(reader["Status"].ToString());

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
                    priceRule = new PriceRuleDTO();
                    priceRule.PriceRuleId = reader["PriceRuleId"].ToString();
                    if (reader["Price"] != DBNull.Value)
                        priceRule.Price = double.Parse(reader["Price"].ToString());
                    if (reader["StartTime"] != DBNull.Value)
                    {
                        if (reader["StartTime"] is TimeSpan ts)
                            priceRule.StartTime = TimeOnly.FromTimeSpan(ts);
                        else
                            priceRule.StartTime = TimeOnly.Parse(reader["StartTime"].ToString());
                    }
                    if (reader["EndTime"] != DBNull.Value)
                    {
                        if (reader["EndTime"] is TimeSpan ts)
                            priceRule.EndTime = TimeOnly.FromTimeSpan(ts);
                        else
                            priceRule.EndTime = TimeOnly.Parse(reader["EndTime"].ToString());
                    }
                    if (reader["StartDate"] != DBNull.Value && !string.IsNullOrEmpty(reader["StartDate"].ToString()))
                    {
                        priceRule.StartDate = DateOnly.FromDateTime(Convert.ToDateTime(reader["StartDate"]));
                    }
                    if (reader["EndDate"] != DBNull.Value && !string.IsNullOrEmpty(reader["EndDate"].ToString()))
                    {
                        priceRule.EndDate = DateOnly.FromDateTime(Convert.ToDateTime(reader["EndDate"]));
                    }
                    priceRule.EndType = reader["EndType"] != DBNull.Value ? reader["EndType"].ToString() : "";
                    priceRule.Description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : "";
                    priceRule.IsActive = reader["Status"] != DBNull.Value ? int.Parse(reader["Status"].ToString()) : 0;
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
            string query = "UPDATE pricerule SET Price = @Price, StartTime = @StartTime, EndTime = @EndTime, StartDate = @StartDate, EndDate = @EndDate, EndType = @EndType, Description = @Description, Status = @Status"
            + " WHERE PriceRuleId = @PriceRuleId";

            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@PriceRuleId", priceRule.PriceRuleId);
                cmd.Parameters.AddWithValue("@Price", priceRule.Price);
                cmd.Parameters.AddWithValue("@StartTime", priceRule.StartTime.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@EndTime", priceRule.EndTime.ToString("HH:mm:ss"));

                if (priceRule.StartDate == null)
                    cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@StartDate", priceRule.StartDate.Value.ToString("yyyy-MM-dd"));

                if (priceRule.EndDate == null)
                    cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@EndDate", priceRule.EndDate.Value.ToString("yyyy-MM-dd"));

                cmd.Parameters.AddWithValue("@EndType", priceRule.EndType);

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
        public bool DeletePriceRule1(string priceRuleId)
        {
            string query = "UPDATE pricerule SET Status = 0 WHERE PriceRuleId = @PriceRuleId";

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
                throw new Exception("Error deleting (hiding) price rule: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }
    }
}

