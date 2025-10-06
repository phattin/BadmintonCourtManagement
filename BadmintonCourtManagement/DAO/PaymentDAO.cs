using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PaymentDAO
    {
        private DBConnection db = new DBConnection();

        // create
        public bool InsertPayment(PaymentDTO payment)
        {
            string query = "INSERT INTO payment (PaymentId, BillProductId, PaymentMethod, TimePayment, AmountPaid, RemainingAmount) VALUES (@PaymentId, @BillProductId, @PaymentMethod, @TimePayment, @AmountPaid, @RemainingAmount)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PaymentId", payment.PaymentId);
                cmd.Parameters.AddWithValue("@BillProductId", payment.BillProductId);
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                cmd.Parameters.AddWithValue("@TimePayment", payment.TimePayment);
                cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
                cmd.Parameters.AddWithValue("@RemainingAmount", payment.RemainingAmount);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting payment: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // lấy tất cả payments
        public List<PaymentDTO> GetAllPayments()
        {
            string query = "SELECT * FROM payment";
            List<PaymentDTO> payments = new List<PaymentDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PaymentDTO payment = new PaymentDTO
                    {
                        PaymentId = reader["PaymentId"].ToString(),
                        BillProductId = reader["BillProductId"].ToString(),
                        PaymentMethod = reader["PaymentMethod"].ToString(),
                        TimePayment = DateTime.Parse(reader["TimePayment"].ToString()),
                        AmountPaid = double.Parse(reader["AmountPaid"].ToString()),
                        RemainingAmount = double.Parse(reader["RemainingAmount"].ToString())
                    };
                    payments.Add(payment);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving payments: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return payments;
        }


        // update
        public bool UpdatePayment(PaymentDTO payment)
        {
            string query = "UPDATE payment SET BillProductId = @BillProductId, PaymentMethod = @PaymentMethod, TimePayment = @TimePayment, AmountPaid = @AmountPaid, RemainingAmount = @RemainingAmount WHERE PaymentId = @PaymentId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PaymentId", payment.PaymentId);
                cmd.Parameters.AddWithValue("@BillProductId", payment.BillProductId);
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                cmd.Parameters.AddWithValue("@TimePayment", payment.TimePayment);
                cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
                cmd.Parameters.AddWithValue("@RemainingAmount", payment.RemainingAmount);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating payment: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // delete
        public bool DeletePayment(string paymentId)
        {
            string query = "DELETE FROM payment WHERE PaymentId = @PaymentId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PaymentId", paymentId);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting payment: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // lấy payment theo BillProductId
        public List<PaymentDTO> GetPaymentsByBillProductId(string billProductId)
        {
            string query = "SELECT * FROM payment WHERE BillProductId = @BillProductId";
            List<PaymentDTO> billDetails = new List<PaymentDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", billProductId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PaymentDTO payment = new PaymentDTO
                    {
                        PaymentId = reader["PaymentId"].ToString(),
                        BillProductId = reader["BillProductId"].ToString(),
                        PaymentMethod = reader["PaymentMethod"].ToString(),
                        TimePayment = DateTime.Parse(reader["TimePayment"].ToString()),
                        AmountPaid = double.Parse(reader["AmountPaid"].ToString()),
                        RemainingAmount = double.Parse(reader["RemainingAmount"].ToString())
                    };
                    billDetails.Add(payment);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving payments by BillProductId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return billDetails;
        }

        // lấy payment theo PaymentId
        public PaymentDTO GetPaymentById(string paymentId)
        {
            string query = "SELECT * FROM payment WHERE PaymentId = @PaymentId";
            PaymentDTO payment = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PaymentId", paymentId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    payment = new PaymentDTO
                    {
                        PaymentId = reader["PaymentId"].ToString(),
                        BillProductId = reader["BillProductId"].ToString(),
                        PaymentMethod = reader["PaymentMethod"].ToString(),
                        TimePayment = DateTime.Parse(reader["TimePayment"].ToString()),
                        AmountPaid = double.Parse(reader["AmountPaid"].ToString()),
                        RemainingAmount = double.Parse(reader["RemainingAmount"].ToString())
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving payment by PaymentId: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return payment;
        }

    }
}