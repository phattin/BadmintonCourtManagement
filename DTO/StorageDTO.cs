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
        private string importBillDetailId = "";
        private string productId = "";
        private int quantity = 0;
        private double price = 0;
        private double totalPrice = 0;
        private DateTime createdAt;
        public enum Option { active, inactive };
        private Option status;

        public string StorageId {  get => storageId; set => storageId = value; }
        public string ImportBillDetailId { get => importBillDetailId; set => importBillDetailId = value; }
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

        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }

        public Option Status { get => status; set => status = value; }

        public StorageDTO() { }

        public StorageDTO(string storageId, string importBillDetailId, 
            string productId, int quantity, double price, 
            DateTime createdAt, Option status)
        {
            StorageId = storageId;
            ImportBillDetailId = importBillDetailId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            CalcTotal();
            CreatedAt = createdAt;
            Status = status;
        }

        public void CalcTotal()
        {
            TotalPrice = Quantity * Price;
        }
    }
}
