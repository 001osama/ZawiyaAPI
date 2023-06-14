using ZawiyaAPI.Data;
using ZawiyaAPI.Models;
using ZawiyaAPI.Repository.IRepository;

namespace ZawiyaAPI.Repository
{
    public class CartItemRepository: Repository<CartItem>, ICartItemRepository
    {
        private readonly ApplicationDbContext _db;
        public CartItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<CartItem> UpdateAsync(CartItem entity)
        {
            _db.CartItems.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
