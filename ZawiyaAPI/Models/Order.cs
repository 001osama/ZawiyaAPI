using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models
{
    public class Order
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; } 
    }
}
