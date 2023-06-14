using ZawiyaAPI.Models;

namespace ZawiyaAPI.Repository.IRepository
{
    public interface IOrderDetailRepository:IRepository<OrderDetail>
    {
        Task<OrderDetail> UpdateAsync(OrderDetail entity);
    }
}
