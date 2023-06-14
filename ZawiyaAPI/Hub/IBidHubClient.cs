using ZawiyaAPI.Models.Dto;

namespace ZawiyaAPI.Hub
{
    public interface IBidHubClient
    {
        Task UpdateBidList(string message, int productId,BidDTO bid);
    }
}
