using ZawiyaAPI.Models;

namespace ZawiyaAPI.Repository.IRepository
{
    public interface ICartItemRepository: IRepository<CartItem>
    {
        Task<CartItem> UpdateAsync(CartItem entity);
    }
}
