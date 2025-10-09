using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonCourtManagement.DTO
{
    public class StorageDTO
    {
        private string storageId = "";
        private string importBillId = "";
        private string productId = "";
        private int quantity = 0;
        private double price = 0;
        private double totalPrice = 0;
        public enum Option { active, inactive };
        private Option status;

        public string StorageId {  get => storageId; set => storageId = value; }
        public string ImportBillId { get => importBillId; set => importBillId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public int Quantity
        {
            get => quantity;
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }
        public double TotalPrice
        {
            get => totalPrice;
            set
            {
                if (quantity >= 0 && price >= 0)
                {
                    totalPrice = price * quantity;
                }
            }
        }
        public Option Status { get => status; set => status = value; }

        public StorageDTO() { }

        public StorageDTO(string storageId, string importBillId, string productId, int quantity, double price, Option status)
        {
            StorageId = storageId;
            ImportBillId = importBillId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            CalcTotal();
            Status = status;
        }

        public void CalcTotal()
        {
            TotalPrice = Quantity * Price;
        }
    }
}
