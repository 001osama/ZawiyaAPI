using ZawiyaAPI.Models;

namespace ZawiyaAPI.Repository.IRepository
{
    public interface IOrderRepository: IRepository<Order>
    {
        Task<Order> UpdateAsync(Order entity);
        Task UpdateStripePaymentId(int orderId, string sessionId, string paymentIntentId);
        Task UpdateStatus(int orderId, string status);
    }
}
