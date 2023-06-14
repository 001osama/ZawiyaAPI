using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models.Dto
{
    public class CartItemDTO
    {
        public int Price { get; set; }
        //public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public int CartId { get; set; }
    }
}
