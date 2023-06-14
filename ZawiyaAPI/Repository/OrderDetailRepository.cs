using ZawiyaAPI.Data;
using ZawiyaAPI.Models;
using ZawiyaAPI.Repository.IRepository;

namespace ZawiyaAPI.Repository
{
    public class OrderDetailRepository: Repository<OrderDetail>, IOrderDetailRepository 
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<OrderDetail> UpdateAsync(OrderDetail entity)
        {
            _db.OrderDetails.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
