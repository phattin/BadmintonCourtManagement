using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.DAO
{
    public class PaymentDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy payment theo PaymentId
        public PaymentDTO GetById(string paymentId)
        {
            string query = "SELECT * FROM payment WHERE PaymentId=@PaymentId AND IsDeleted=0";
            PaymentDTO payment = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PaymentId", paymentId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    payment = new PaymentDTO()
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        PaymentId = reader["PaymentId"].ToString(),
                        PaymentMethod = reader["PaymentMethod"].ToString(),
                        TimePayment = Convert.ToDateTime(reader["TimePayment"]),
                        AmountPaid = Convert.ToInt32(reader["AmountPaid"]),
                        RemainingAmount = Convert.ToInt32(reader["RemainingAmount"])
                    };
                }
                reader.Close();
            }
            finally
            {
                db.CloseConnection();
            }
            return payment;
        }

        // Lấy tất cả payment chưa xóa
        public List<PaymentDTO> GetAllPayment()
        {
            string query = "SELECT * FROM payment WHERE IsDeleted=0";
            List<PaymentDTO> list = new List<PaymentDTO>();
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PaymentDTO()
                    {
                        BillProductId = reader["BillProductId"].ToString(),
                        PaymentId = reader["PaymentId"].ToString(),
                        PaymentMethod = reader["PaymentMethod"].ToString(),
                        TimePayment = Convert.ToDateTime(reader["TimePayment"]),
                        AmountPaid = Convert.ToInt32(reader["AmountPaid"]),
                        RemainingAmount = Convert.ToInt32(reader["RemainingAmount"])
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

        // Thêm payment
        public bool InsertPayment(PaymentDTO payment)
        {
            string query = "INSERT INTO payment (BillProductId, PaymentId, PaymentMethod, TimePayment, AmountPaid, RemainingAmount, IsDeleted) " +
                           "VALUES (@BillProductId, @PaymentId, @PaymentMethod, @TimePayment, @AmountPaid, @RemainingAmount, 0)";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", payment.BillProductId);
                cmd.Parameters.AddWithValue("@PaymentId", payment.PaymentId);
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                cmd.Parameters.AddWithValue("@TimePayment", payment.TimePayment);
                cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
                cmd.Parameters.AddWithValue("@RemainingAmount", payment.RemainingAmount);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Cập nhật payment
        public bool UpdatePayment(PaymentDTO payment)
        {
            string query = "UPDATE payment SET BillProductId=@BillProductId, PaymentMethod=@PaymentMethod, TimePayment=@TimePayment, " +
                           "AmountPaid=@AmountPaid, RemainingAmount=@RemainingAmount " +
                           "WHERE PaymentId=@PaymentId AND IsDeleted=0";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@BillProductId", payment.BillProductId);
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                cmd.Parameters.AddWithValue("@TimePayment", payment.TimePayment);
                cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
                cmd.Parameters.AddWithValue("@RemainingAmount", payment.RemainingAmount);
                cmd.Parameters.AddWithValue("@PaymentId", payment.PaymentId);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnection();
            }
            return result > 0;
        }

        // Xóa mềm payment (IsDeleted = 1)
        public bool DeletePayment(string paymentId)
        {
            string query = "UPDATE payment SET IsDeleted=1 WHERE PaymentId=@PaymentId";
            int result = 0;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@PaymentId", paymentId);
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
