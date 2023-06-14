using Stripe;
using ZawiyaAPI.Data;
using ZawiyaAPI.Models;
using ZawiyaAPI.Repository.IRepository;

namespace ZawiyaAPI.Repository
{
    public class OrderRepository: Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public async Task<Order> UpdateAsync(Order entity)
        {
            _db.Orders.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateStripePaymentId(int orderId, string sessionId, string paymentIntentId)
        {
            var entity = await _db.Orders.FindAsync(orderId);
            entity.SessionId = sessionId;
            entity.PaymentIntentId = paymentIntentId;

            _db.Orders.Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateStatus(int orderId, string status)
        {
            var entity = await _db.Orders.FindAsync(orderId);
            entity.Status = status;

            _db.Orders.Update(entity);
            await _db.SaveChangesAsync();

        }
    }
}
