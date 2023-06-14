using ZawiyaAPI.Models;

namespace ZawiyaAPI.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        Task<ShoppingCart> UpdateAsync(ShoppingCart entity);
    }
}
