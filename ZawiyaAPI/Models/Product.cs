using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models
{
    public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentPrice { get; set; }
        public DateTime BidEndTime { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime BidStartTime { get; set; }
        public int StartingPrice { get; set; }
        public ICollection<Bid> Bids { get; } = new List<Bid>();


        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
     }
}
