using Microsoft.EntityFrameworkCore;
using System;

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
        public async Task<List<Item>> GetSpecificItemsAsync(DateTime? billdate)
        {
            var formattedBillDate = billdate.HasValue ? billdate.Value : DateTime.MinValue;

            var returnitems = _db.Item.Where(p => p.Created.HasValue && p.Created.Value == formattedBillDate);
            return await returnitems.ToListAsync();
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
        public async Task<Item> UpdateItemAsync(Item item)
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
