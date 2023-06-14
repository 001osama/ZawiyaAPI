using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models.Dto
{
    public class ShoppingCartDTO
    {
        public ICollection<CartItem>? CartItems { get; } = new List<CartItem>();
        public string ApplicationUserId { get; set; }
        public int TotalPrice { get; set; }
    }
}
