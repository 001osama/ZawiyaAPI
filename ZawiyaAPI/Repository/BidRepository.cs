using Microsoft.EntityFrameworkCore;
using ZawiyaAPI.Data;
using ZawiyaAPI.Models;
using ZawiyaAPI.Repository.IRepository;

namespace ZawiyaAPI.Repository
{
    public class BidRepository: Repository<Bid>, IBidRepository
    {
        private readonly ApplicationDbContext _db;

        public BidRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Bid> UpdateAsync(Bid entity)
        {
            _db.Bids.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Bid> GetHighestBid(int productId)
        {
            var highestBid = await _db.Bids.OrderByDescending(x => x.Amount).FirstOrDefaultAsync(x => x.ProductId == productId);
            return highestBid;
        }


    }
}
