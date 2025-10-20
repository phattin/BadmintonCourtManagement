using System;

namespace BadmintonCourtManagement.DTO
{
    public class PaymentDTO
    {
        private string paymentId = "";
        private string billProductId = "";
        private string paymentMethod = "";
        private DateTime timePayment = DateTime.Now;
        private double amountPaid = 0;
        private double remainingAmount = 0;

        public string PaymentId { get => paymentId; set => paymentId = value; }
        public string BillProductId { get => billProductId; set => billProductId = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public DateTime TimePayment { get => timePayment; set => timePayment = value; }
        public double AmountPaid
        {
            get => amountPaid;
            set
            { 
                if (value >= 0)
                {
                    amountPaid = value;
                }
            }
        }
        public double RemainingAmount
        {
            get => remainingAmount;
            set
            {
                if (value >= 0)
                {
                    remainingAmount = value;
                }
            }
        }

        public PaymentDTO() { }

        public PaymentDTO(string paymentId, string billProductId, string paymentMethod, DateTime timePayment, double amountPaid, double remainingAmount)
        {
            this.PaymentId = paymentId;
            this.BillProductId = billProductId;
            this.PaymentMethod = paymentMethod;
            this.TimePayment = timePayment;
            this.AmountPaid = amountPaid;
            this.RemainingAmount = remainingAmount;
        }
    }


}