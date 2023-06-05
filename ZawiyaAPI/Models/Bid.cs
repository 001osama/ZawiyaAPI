using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models
{
    public class Bid
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BidId { get; set; }
        public int Amount { get; set; }
        public DateTime BidTime { get; set; }
        public bool IsCurrentBid { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Products { get; set; }

    }
}
