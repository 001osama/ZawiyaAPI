using Microsoft.EntityFrameworkCore;
using ZawiyaAPI.Data;
using ZawiyaAPI.Models;
using ZawiyaAPI.Repository.IRepository;

namespace ZawiyaAPI.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        
        public async Task<Product> UpdateAsync(Product entity)
        {
            entity.UpdatedDate = DateTime.Now;
            var existingEntity = await _db.Products.FirstOrDefaultAsync(p => p.ProductId == entity.ProductId);
            _db.Entry(existingEntity).CurrentValues.SetValues(entity);
            await _db.SaveChangesAsync();
            return existingEntity;
        }
    }
}
