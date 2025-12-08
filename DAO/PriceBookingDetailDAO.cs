using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PriceBookingDetailDAO
    {
        private DBConnection db = new DBConnection();


        // create
        public bool InsertPriceBookingDetail(PriceBookingDetailDTO bill)
        {
            string query = "INSERT INTO pricebookingdetail (BillBookingId, PriceRuleId, PriceApplied) VALUES (@BillBookingId, @PriceRuleId, @PriceApplied)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillBookingId", bill.BillBookingId);
                cmd.Parameters.AddWithValue("@PriceRuleId", bill.PriceRuleId);
                cmd.Parameters.AddWithValue("@PriceApplied", bill.PriceApplied);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting pricebooking detail: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // read

        public List<PriceBookingDetailDTO> GetPriceBookingDetailsByPriceBookingId(string importBillId)
        {
            string query = "SELECT * FROM pricebookingdetail WHERE BillBookingId = @BillBookingId";
            List<PriceBookingDetailDTO> billDetails = new List<PriceBookingDetailDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillBookingId", importBillId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    billDetails.Add(new PriceBookingDetailDTO
                    {
                        BillBookingId = reader["BillBookingId"].ToString(),
                        PriceRuleId = reader["PriceRuleId"].ToString(),
                        PriceApplied = double.Parse(reader["PriceApplied"].ToString()),
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving price booking details by PriceBookingId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return billDetails;
        }

        
    }
}
