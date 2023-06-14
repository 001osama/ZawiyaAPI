using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models.Dto
{
    public class OrderDTO
    {
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public string? Status { get; set; }
        public int BuyerId { get; set; }
    }
}
