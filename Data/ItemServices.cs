using Microsoft.EntityFrameworkCore;

namespace ItemPriceHistoryTracker.Data
{
    public class ItemServices
    {
        private ItemDbContext _db;
        public ItemServices(ItemDbContext db)
        {
            this._db = db;
        }
        public async Task<List<Item>> GetItemsAsync()
        {
            return await _db.Item.ToListAsync();
        }

        public async Task<Item> AddItemAsync(Item item)
        {
            try
            {
                _db.Item.Add(item);
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }
        public async Task<Item> UpdateProductAsync(Item item)
        {
            try
            {
                var itemExist = _db.Item.FirstOrDefault(p => p.Id == item.Id);
                if (itemExist != null)
                {
                    _db.Update(item);
                    await _db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }
        public async Task DeleteItemAsync(Item item)
        {
            try
            {
                _db.Item.Remove(item);
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
