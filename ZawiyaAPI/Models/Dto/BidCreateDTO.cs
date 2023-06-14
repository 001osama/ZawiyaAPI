using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models.Dto
{
    public class BidCreateDTO
    {
        public int Amount { get; set; }
        public DateTime BidTime { get; set; }
        public bool IsCurrentBid { get; set; }
        public int BuyerId { get; set; }
        public int ProductId { get; set; }
    }
}
