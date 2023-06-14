using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ZawiyaAPI.Models
{
    public class ShoppingCart
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public ICollection<CartItem> CartItems { get; } = new List<CartItem>();
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


        [NotMapped]
        public int TotalPrice { get; set; }
    }
}
