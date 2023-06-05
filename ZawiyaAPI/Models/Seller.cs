using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ZawiyaAPI.Models
{
    public class Seller
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SellerId { get; set; }
        public string Address { get; set; } 
        public string PhoneNumber { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ICollection<Product> Products { get; } = new List<Product>();


        [ForeignKey("Users")]
        public string UserId { get; set; }
        public ApplicationUser Users { get; set; }

    }
}
