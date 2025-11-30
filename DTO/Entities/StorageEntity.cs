using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DTO.Entities
{
    public class StorageEntity
    {
        [Table("Storage")]
        public class Storage
        {
            [Key]
            [Required]
            public string StorageId { get; set; } = "";

            [Required]
            public string ImportBillDetailId { get; set; } = "";

            [Required]
            public string ProductId { get; set; } = "";

            private int _quantity = 0;

            [Required]
            public int Quantity { 
                get => _quantity; 
                set { 
                    if (value < 0) 
                        throw new ArgumentException("Quantity cannot be negative.");
                    _quantity = value;
                }
            }

            private double _price = 0;
            [Required]
            [Column(TypeName = "decimal(18,2)")]
            public double Price { 
                get => _price; 
                set { 
                    if (value < 0) 
                        throw new ArgumentException("Price cannot be negative.");
                    _price = value;
                }
            }

            [Required]
            [Column(TypeName = "decimal(18,2)")]
            // chỉ cho phép set bởi hàm calcTotal
            public double TotalPrice { get; private set; } = 0;

            [Required]
            public DateTime CreatedAt { get; set; } = DateTime.Now;

            public enum Option { active, inactive };

            [Required]
            public Option Status { get; set; } = Option.active;

            public Storage() {}

            public Storage(string storageId, string importBillDetailId, string productId, int quantity, double price, DateTime createdAt, Option status)
            {
                StorageId = storageId;
                ImportBillDetailId = importBillDetailId;
                ProductId = productId;
                Quantity = quantity;
                Price = price;
                CreatedAt = createdAt;
                Status = status;
                CalcTotal();
            }

            public void CalcTotal()
            {
                TotalPrice = Quantity * Price;
            }
        }
    }
}
