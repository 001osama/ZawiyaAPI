using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models.Dto
{
    public class BidDTO
    {
        public int BidId { get; set; }
        public int Amount { get; set; }
        public DateTime BidTime { get; set; }
        public bool IsCurrentBid { get; set; }
        public int ProductId { get; set; }
    }
}
