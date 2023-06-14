using ZawiyaAPI.Models;

namespace ZawiyaAPI.Repository.IRepository
{
    public interface IBidRepository: IRepository<Bid>
    {
        Task<Bid> UpdateAsync(Bid entity);
        Task<Bid> GetHighestBid(int productId);
    }
}

