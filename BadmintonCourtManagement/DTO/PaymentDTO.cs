namespace BadmintonCourtManagement.DTO
{
    class PaymentDTO
    {
        private string billProductId = "";
        private string paymentId = "";
        private string paymentMethod = "";
        private DateTime timePayment;
        private int amountPaid = 0;
        private int remainingAmount = 0;

        public string BillProductId { get => billProductId; set => billProductId = value; }
        public string PaymentId { get => paymentId; set => paymentId = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public DateTime TimePayment { get => timePayment; set => timePayment = value; }
        public int AmountPaid { get => amountPaid; set => amountPaid = value; }
        public int RemainingAmount { get => remainingAmount; set => remainingAmount = value; }

        public PaymentDTO() { }

        public PaymentDTO(string billProductId, string paymentId, string paymentMethod, DateTime timePayment, int amountPaid, int remainingAmount)
        {
            this.BillProductId = billProductId;
            this.PaymentId = paymentId;
            this.PaymentMethod = paymentMethod;
            this.TimePayment = timePayment;
            this.AmountPaid = amountPaid;
            this.RemainingAmount = remainingAmount;
        }
    }
}
