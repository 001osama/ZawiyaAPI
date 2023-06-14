using Microsoft.AspNetCore.SignalR;
using ZawiyaAPI.Models.Dto;

namespace ZawiyaAPI.Hub
{
    public class BidHub : Hub<IBidHubClient>
    {
        public async Task UpdateBidList(string message, int productId, BidDTO bid)
        {
            await Clients.All.UpdateBidList(message, productId, bid);
        }
    }
}
