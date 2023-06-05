using ZawiyaAPI.Models;

namespace ZawiyaAPI.Repository.IRepository
{
    public interface IProductRepository: IRepository<Product>
    {
        Task<Product> UpdateAsync(Product entity);
    }
}
