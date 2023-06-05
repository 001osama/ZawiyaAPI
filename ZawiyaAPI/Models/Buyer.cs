using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models
{
    public class Buyer
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuyerId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ICollection<Bid> Bids { get; } = new List<Bid>();
        public ICollection<Order> Orders { get; } = new List<Order>();

        [ForeignKey("Users")]
        public string UserId { get; set; }
        public ApplicationUser Users{ get; set; }
    }
}
