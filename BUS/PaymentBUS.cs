using System;
using System.Collections.Generic;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.BUS
{ 
    public class PaymentBUS
    {
        private PaymentDAO dao = new PaymentDAO();

        public List<PaymentDTO> GetPaymentsByBillProductId(string billProductId)
        {
            return dao.GetPaymentsByBillProductId(billProductId);
        }

        public PaymentDTO GetPaymentById(string id)
        {
            return dao.GetPaymentById(id);
        }

        public List<PaymentDTO> GetAllPayments()
        {
            return dao.GetAllPayments();
        }

        public bool InsertPayment(PaymentDTO payment)
        {
            // Kiểm tra xem payment đã tồn tại chưa
            var existing = dao.GetPaymentById(payment.PaymentId);
            if (existing != null)
                throw new Exception("Payment đã tồn tại!");

            return dao.InsertPayment(payment);
        }

        public bool UpdatePayment(PaymentDTO payment)
        {
            var existing = dao.GetPaymentById(payment.PaymentId);
            if (existing == null)
                throw new Exception("Payment không tồn tại!");

            return dao.UpdatePayment(payment);
        }

        public bool DeletePayment(string id)
        {
            var existing = dao.GetPaymentById(id);
            if (existing == null)
                throw new Exception("Payment không tồn tại!");

            return dao.DeletePayment(id);
        }
    }
}